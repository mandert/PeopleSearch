using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeopleSearchDatabase;
using PeopleSearchDatabase.Models;
using PeopleSearchTests.Mocks.PeopleSearchDatabase;

namespace PeopleSearchTests.Tests
{
    /// <summary>
    /// Test Cases for the PeopleSearchDatabase Project
    /// </summary>
    [TestClass]
    public class PeopleSearchDatabaseTests
    {
        [TestMethod]
        public void GeneratePeopleNameLookup_ValidName_ReturnsExpectedDetails()
        {
            // Arrange
            MockPeopleSearch mockPeopleSearch = new MockPeopleSearch();
            Methods methods = new Methods(mockPeopleSearch, 5);
            Person person = new Person()
            {
                FirstName = "John",
                LastName = "Doe"
            };
            int expected = 16;

            // Act
            methods.AddPeopleNameLookup(person);
            int actual = mockPeopleSearch.NumberOfPeopleNameLookupAdded;

            // Assert
            Assert.AreEqual(expected, actual, 0, string.Format("Number of lookup names generated unexpected for \"{0} {1}\". {2} expected, {3} actual.", person.FirstName, person.LastName, expected, actual));
        }
    }
}
