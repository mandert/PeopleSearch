using System.Collections.Generic;

namespace PeopleSearchService.Models
{
    /// <summary>
    /// PeopleSearch Service SearchResults Object
    /// </summary>
    public class SearchResults
    {
        public int ResultsFound { get; set; }
        public List<Person> People { get; set; }
    }
}
