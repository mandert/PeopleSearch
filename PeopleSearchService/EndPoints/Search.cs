using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using PeopleSearchService.Interfaces;
using PeopleSearchService.Mappers;
using PeopleSearchService.Models;


namespace PeopleSearchService.EndPoints
{
    /// <summary>
    /// Search EndPoint Class that contains all Search related methods.
    /// </summary>
    public class Search : ISearch
    {
        /// <summary>
        /// Lazy loading private variable used to store the parameterized query used to get the
        /// count of records found when searching against first and last name.
        /// </summary>
        private string _searchFirstAndLastNameCountQuery;
        private string SearchFirstAndLastNameCountQuery
        {
            get
            {
                if (string.IsNullOrEmpty(_searchFirstAndLastNameCountQuery))
                {
                    _searchFirstAndLastNameCountQuery = GetSearchFirstAndLastNameCountQuery();
                }

                return _searchFirstAndLastNameCountQuery; 
            }
        }

        /// <summary>
        /// Method to search both first and last name fields using a single keyword.
        /// </summary>
        /// <param name="searchString">String used to search against a person's first and last names.</param>
        /// <param name="maxRecordsToReturn">Maximum number of records to return (Used for paging functionality).</param>
        /// <param name="pageNumber">Page number requested (used to determine offset).</param>
        /// <param name="searchDelayMs">Number representing the number of milliseconds to wait before returning the response.
        /// This was requested as part of the requirements to enable the ability to test long running search transations no
        /// matter how efficient the search is.
        /// </param>
        /// <returns>Search Results which contains a count of the total number of matching records as well as the
        /// requested range of records.</returns>
        public SearchResults SearchFirstAndLastName(string searchString, int maxRecordsToReturn, int pageNumber, int searchDelayMs)
        {
            List<Person> peopleToReturn = null;
            int totalMatchingResults = 0;
            using (PeopleSearchDatabase.PeopleSearch peopleSearchDatabase = new PeopleSearchDatabase.PeopleSearch())
            {
                // Prepare and call parameterized query to get the count of total matching records.
                SqlParameter totalMatchingNamePartSqlParameter = new SqlParameter("@namePart", searchString.Replace("'", "''"));
                DbRawSqlQuery<int> totalMatchingResultsQuery = peopleSearchDatabase.Database.SqlQuery<int>(SearchFirstAndLastNameCountQuery, totalMatchingNamePartSqlParameter);
                totalMatchingResults = totalMatchingResultsQuery.Single();

                // Prepare and call a dynamically parameterized query (you can't use a parameter to specify how many rows to 
                // return> to return the requested range of results.
                SqlParameter peopleResultsNamePartSqlParameter = new SqlParameter("@namePart", searchString.Replace("'", "''"));
                SqlParameter startIndexSqlParameter = new SqlParameter("@startIndex",
                    (pageNumber - 1) * maxRecordsToReturn);
                DbRawSqlQuery<PeopleSearchDatabase.Models.Person> peopleSearchResultsQuery =
                    peopleSearchDatabase.People.SqlQuery(GetSearchFirstAndLastNameQuery(maxRecordsToReturn),
                        peopleResultsNamePartSqlParameter, startIndexSqlParameter);
                peopleToReturn = peopleSearchResultsQuery.ToList().ToPeopleServiceModel();
            }

            // Per the requirements, we want to allow the consumer of this service method to enforce a delay on returning the
            // search results to enure the consumer handle's delays appropriately.
            Thread.Sleep(searchDelayMs);

            // Build the return SearchResults object.
            SearchResults searchResults = new SearchResults()
            {
                ResultsFound = totalMatchingResults,
                People = peopleToReturn
            };

            return searchResults;
        }

        /// <summary>
        /// Method to build the SearchFirstAndLastName Count Query.
        /// </summary>
        /// <returns>Parameterized SearchFirstAndLastName Count Query</returns>
        private string GetSearchFirstAndLastNameCountQuery()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SELECT COUNT(DISTINCT A.[Person_PersonId])");
            sb.AppendLine("  FROM dbo.[PeopleNameLookups] A");
            sb.AppendLine("WHERE A.[NamePart] = @namePart;");

            return sb.ToString();
        }

        /// <summary>
        /// Method to build the SearchFirstAndLastName Query.
        /// </summary>
        /// <param name="maxRecordsToReturn">Maximum number of records to return (Used for paging functionality).</param>
        /// <returns>Parameterized SearchFirstAndLastName Query</returns>
        private string GetSearchFirstAndLastNameQuery(int maxRecordsToReturn)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("SELECT TOP {0} *", maxRecordsToReturn));
            sb.AppendLine("              FROM (");
            sb.AppendLine("                    SELECT ROW_NUMBER() OVER(ORDER BY B.[MatchStrength] DESC) AS [RowNumber]");
            sb.AppendLine("                         , B.[MatchStrength]");
            sb.AppendLine("                         , C.*");
            sb.AppendLine("                    FROM (");
            sb.AppendLine("                          SELECT A.[Person_PersonId]");
            sb.AppendLine("                              , SUM(CASE");
            sb.AppendLine("                                       WHEN A.[NameStart] = 1 THEN 2 -- Give a little more value to records that start with the search string");
            sb.AppendLine("                                       ELSE 1");
            sb.AppendLine("                                    END) AS [MatchStrength]");
            sb.AppendLine("                          FROM dbo.[PeopleNameLookups] A");
            sb.AppendLine("                          WHERE A.[NamePart] = @namePart");
            sb.AppendLine("                          GROUP BY A.[Person_PersonId]");
            sb.AppendLine("                         ) AS B");
            sb.AppendLine("                       , dbo.[People] C");
            sb.AppendLine("                    WHERE B.[Person_PersonId] = C.[PersonId]");
            sb.AppendLine("                   ) AS D LEFT OUTER JOIN dbo.[Addresses] E");
            sb.AppendLine("              ON D.[Address_AddressId] = E.[AddressId]");
            sb.AppendLine("              WHERE D.[RowNumber] > @startIndex");

            return sb.ToString();
        }
    }
}
