using System.Collections.Generic;
using PeopleSearch.Models;

namespace PeopleSearch.Mappers
{
    /// <summary>
    /// Class that contains SearchForPeopleResponseMapper ViewModel mapping functions.
    /// </summary>
    public static class SearchForPeopleResponseMapper
    {
        /// <summary>
        /// Extension method to map a Service SearchResults Model to the View SearchForPeopleResponse Model.
        /// </summary>
        /// <param name="searchResults">Service SearchResults Model to map from.</param>
        /// <returns>Corresponding View SearchForPeopleResponse Model</returns>
        public static SearchForPeopleResponse ToSearchForPeopleResponseViewModel(this PeopleSearchService.Models.SearchResults searchResults)
        {
            SearchForPeopleResponse searchForPeopleResponse = new SearchForPeopleResponse()
            {
                ResultsFound = searchResults.ResultsFound,
                Peoples = (searchResults.People == null) ? new List<Person>() : searchResults.People.ToPeopleViewModel()
            };

            return searchForPeopleResponse;
        }
    }
}