namespace PeopleSearch.Models
{
    /// <summary>
    /// PeopleSearch View Person Object
    /// </summary>
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public int Age { get; set; }
        public string Interests { get; set; }
        public string PictureUrl { get; set; }
    }
}