using System.ServiceModel;
using PeopleSearchService.Models;

namespace PeopleSearchService.Interfaces
{
    /// <summary>
    /// Service Contract Search End Point Interface
    /// </summary>
    [ServiceContract]
    public interface ISearch
    {
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
        [OperationContract]
        SearchResults SearchFirstAndLastName(string searchString, int maxRecordsToReturn, int pageNumber, int searchDelayMs);
    }
}
