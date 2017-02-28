using PeopleSearchDatabase;
using PeopleSearchDatabase.Models;

namespace PeopleSearchTests.Mocks.PeopleSearchDatabase
{
    /// <summary>
    /// Mocked PeopleSearch DbContext for Unit Testing Purposes
    /// </summary>
    public class MockPeopleSearch : IPeopleSearch
    {
        private int _numberOfPeopleAdded;
        private int _numberOfPeopleNameLookupAdded;

        public int NumberOfPeopleAdded
        {
            get { return _numberOfPeopleAdded; }
        }

        public int NumberOfPeopleNameLookupAdded
        {
            get { return _numberOfPeopleNameLookupAdded; }
        }

        public Person AddPerson(Person person)
        {
            _numberOfPeopleAdded++;
            return person;
        }

        public PeopleNameLookup AddPeopleNameLookup(PeopleNameLookup peopleNameLookup)
        {
            _numberOfPeopleNameLookupAdded++;
            return peopleNameLookup;
        }

        public int ExecuteSaveChanges()
        {
            return _numberOfPeopleAdded + _numberOfPeopleNameLookupAdded;
        }
    }
}
