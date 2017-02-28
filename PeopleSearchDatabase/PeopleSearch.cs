using System.Data.Entity;
using PeopleSearchDatabase.Models;

namespace PeopleSearchDatabase
{
    /// <summary>
    /// Interface to avoid tight coupling and enable mocked objects for unit testing.
    /// </summary>
    public interface IPeopleSearch
    {
        /// <summary>
        /// Method to add a Person to the PeopleSearch database.
        /// </summary>
        /// <param name="person">Person record to add.</param>
        /// <returns>Added Person with record ID.</returns>
        Person AddPerson(Person person);

        /// <summary>
        /// Method to add a PeopleNameLookup to the PeopleSearch database.
        /// </summary>
        /// <param name="peopleNameLookup">PeopleNameLookup record to add.</param>
        /// <returns>Add PeopleNameLookup with database ID.</returns>
        PeopleNameLookup AddPeopleNameLookup(PeopleNameLookup peopleNameLookup);

        /// <summary>
        /// Method to save/commit PeopleSearch database changes.
        /// </summary>
        /// <returns>The number of objects written to the underlying database.</returns>
        int ExecuteSaveChanges();
    }

    /// <summary>
    /// PeopleSearch DbContext class needed for Entity First Code First database development.
    /// </summary>
    public class PeopleSearch : DbContext, IPeopleSearch
    {
        // DbSets defined for Entity First Code First database development.
        public DbSet<Person> People { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<PeopleNameLookup> PeopleNameLookups { get; set; }

        /// <summary>
        /// Method to add a Person to the PeopleSearch database.
        /// </summary>
        /// <param name="person">Person record to add.</param>
        /// <returns>Added Person with record ID.</returns>
        public Person AddPerson(Person person)
        {
            return People.Add(person);
        }

        /// <summary>
        /// Method to add a PeopleNameLookup to the PeopleSearch database.
        /// </summary>
        /// <param name="peopleNameLookup">PeopleNameLookup record to add.</param>
        /// <returns>Add PeopleNameLookup with database ID.</returns>
        public PeopleNameLookup AddPeopleNameLookup(PeopleNameLookup peopleNameLookup)
        {
            return PeopleNameLookups.Add(peopleNameLookup);
        }

        /// <summary>
        /// Method to save/commit PeopleSearch database changes.
        /// </summary>
        /// <returns>The number of objects written to the underlying database.</returns>
        public int ExecuteSaveChanges()
        {
            return SaveChanges();
        }
    }
}
