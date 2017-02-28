namespace PeopleSearch.Models
{
    /// <summary>
    /// PeopleSearch SearchForPeopleRequest Object used in the "SearchForPeople" action in the HomeController.
    /// </summary>
    public class SearchForPeopleRequest
    {
        public string Keyword { get; set; }
        public int RequestedPage { get; set; }
        public int ItemsPerPage { get; set; }
        public int SearchDelayMs { get; set; }
    }
}