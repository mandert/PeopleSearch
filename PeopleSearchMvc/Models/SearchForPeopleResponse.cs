using System.Collections.Generic;

namespace PeopleSearch.Models
{
    /// <summary>
    /// PeopleSearch SearchForPeopleResponse Object used in the "SearchForPeople" action in the HomeController.
    /// </summary>
    public class SearchForPeopleResponse
    {
        public int ResultsFound { get; set; }
        public List<Person> Peoples { get; set; }
    }
}