using System;
using PeopleSearch.Mappers;
using PeopleSearch.Models;
using System.Web.Mvc;

namespace PeopleSearch.Controllers
{
    /// <summary>
    /// Controller class for the default "Home" path.
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Default HomeController action.
        /// </summary>
        /// <returns>Default HomeController view.</returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Endpoint for client request to search for people.
        /// </summary>
        /// <param name="searchForPeopleRequest">Object containing request properties needed for the SearchForPeople function.</param>
        /// <returns>Json object containing the search results that meet the search criteria.</returns>
        public JsonResult SearchForPeople(SearchForPeopleRequest searchForPeopleRequest)
        {
            try
            {
                // Simply calling the PeopleSearchService endpoint assembly directly.  This was done to simplify this 
                // assignment.  Ideally, a service should reside on a separate machine and would require the call to 
                // be made over the network.
                PeopleSearchService.Interfaces.ISearch searchService = new PeopleSearchService.EndPoints.Search();

                // The actual service call.
                PeopleSearchService.Models.SearchResults searchResults = searchService.SearchFirstAndLastName(searchForPeopleRequest.Keyword, searchForPeopleRequest.ItemsPerPage, searchForPeopleRequest.RequestedPage, searchForPeopleRequest.SearchDelayMs);

                // Covert the response to the ViewModel object and return as Json.
                return Json(searchResults.ToSearchForPeopleResponseViewModel()); 
            }
            catch (Exception e)
            {
                // Upon error write the exception to the Window Event Log and return an error with an empty Json object.
                Utils.WriteExceptionToEventLog(e);
                Response.StatusCode = 500;
                return Json(null);
            }
        }
    }
}
