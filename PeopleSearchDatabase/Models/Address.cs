namespace PeopleSearchDatabase.Models
{
    /// <summary>
    /// PeopleSearch Database Address Object
    /// </summary>
    public class Address
    {
        public int AddressId { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
}
