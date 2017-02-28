namespace PeopleSearchDatabase.Models
{
    /// <summary>
    /// PeopleSearch Database Person Object
    /// </summary>
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Interests { get; set; }
        public string PictureUrl { get; set; }

        // Nothing that from a data modeling perspective I'd recommend making this a List<Address>
        // since people will likely have more than one address (Home, Work, etc). However, for this
        // assignment I'm simply limiting it to one Address.
        public virtual Address Address { get; set; }
    }
}
