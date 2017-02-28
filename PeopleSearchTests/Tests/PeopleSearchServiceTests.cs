using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeopleSearchService.Mappers;

namespace PeopleSearchTests.Tests
{
    /// <summary>
    /// Test Cases for the PeopleSearchService Project
    /// </summary>
    [TestClass]
    public class PeopleSearchServiceTests
    {
        [TestMethod]
        public void Mapping_DatabaseAddressToServiceModel_NullAddressMapsSuccessfully()
        {
            // Arrange
            PeopleSearchDatabase.Models.Address databaseAddress = null;

            // Act
            PeopleSearchService.Models.Address actual = databaseAddress.ToAddressServiceModel();

            // Assert
            Assert.AreNotEqual(null, actual, "Database to service model Address null test failed.");
        }

        [TestMethod]
        public void Mapping_DatabaseAddressToServiceModel_StreetLine1MapsSuccessfully()
        {
            // Arrange
            string streetLine1 = "123 State St";
            string streetLine2 = "Apt 456";
            string city = "Minneapolis";
            string state = "MN";
            string zip = "55401";
            PeopleSearchDatabase.Models.Address databaseAddress = new PeopleSearchDatabase.Models.Address()
            {
                StreetLine1 = streetLine1,
                StreetLine2 = streetLine2,
                City = city,
                State = state,
                Zip = zip
            };
            string expected = streetLine1;

            // Act
            PeopleSearchService.Models.Address addressServiceModel = databaseAddress.ToAddressServiceModel();
            string actual = addressServiceModel.StreetLine1;

            // Assert
            Assert.AreEqual(expected, actual, string.Format("Database to service model Address StreetLine1 failed. \"{0}\" expected, \"{1}\" actual.", expected, actual));
        }

        [TestMethod]
        public void Mapping_DatabaseAddressToServiceModel_StreetLine2MapsSuccessfully()
        {
            // Arrange
            string streetLine1 = "123 State St";
            string streetLine2 = "Apt 456";
            string city = "Minneapolis";
            string state = "MN";
            string zip = "55401";
            PeopleSearchDatabase.Models.Address databaseAddress = new PeopleSearchDatabase.Models.Address()
            {
                StreetLine1 = streetLine1,
                StreetLine2 = streetLine2,
                City = city,
                State = state,
                Zip = zip
            };
            string expected = streetLine2;

            // Act
            PeopleSearchService.Models.Address addressServiceModel = databaseAddress.ToAddressServiceModel();
            string actual = addressServiceModel.StreetLine2;

            // Assert
            Assert.AreEqual(expected, actual, string.Format("Database to service model Address StreetLine2 failed. \"{0}\" expected, \"{1}\" actual.", expected, actual));
        }

        [TestMethod]
        public void Mapping_DatabaseAddressToServiceModel_CityMapsSuccessfully()
        {
            // Arrange
            string streetLine1 = "123 State St";
            string streetLine2 = "Apt 456";
            string city = "Minneapolis";
            string state = "MN";
            string zip = "55401";
            PeopleSearchDatabase.Models.Address databaseAddress = new PeopleSearchDatabase.Models.Address()
            {
                StreetLine1 = streetLine1,
                StreetLine2 = streetLine2,
                City = city,
                State = state,
                Zip = zip
            };
            string expected = city;

            // Act
            PeopleSearchService.Models.Address addressServiceModel = databaseAddress.ToAddressServiceModel();
            string actual = addressServiceModel.City;

            // Assert
            Assert.AreEqual(expected, actual, string.Format("Database to service model Address City failed. \"{0}\" expected, \"{1}\" actual.", expected, actual));
        }

        [TestMethod]
        public void Mapping_DatabaseAddressToServiceModel_StateMapsSuccessfully()
        {
            // Arrange
            string streetLine1 = "123 State St";
            string streetLine2 = "Apt 456";
            string city = "Minneapolis";
            string state = "MN";
            string zip = "55401";
            PeopleSearchDatabase.Models.Address databaseAddress = new PeopleSearchDatabase.Models.Address()
            {
                StreetLine1 = streetLine1,
                StreetLine2 = streetLine2,
                City = city,
                State = state,
                Zip = zip
            };
            string expected = state;

            // Act
            PeopleSearchService.Models.Address addressServiceModel = databaseAddress.ToAddressServiceModel();
            string actual = addressServiceModel.State;

            // Assert
            Assert.AreEqual(expected, actual, string.Format("Database to service model Address State failed. \"{0}\" expected, \"{1}\" actual.", expected, actual));
        }

        [TestMethod]
        public void Mapping_DatabaseAddressToServiceModel_ZipMapsSuccessfully()
        {
            // Arrange
            string streetLine1 = "123 State St";
            string streetLine2 = "Apt 456";
            string city = "Minneapolis";
            string state = "MN";
            string zip = "55401";
            PeopleSearchDatabase.Models.Address databaseAddress = new PeopleSearchDatabase.Models.Address()
            {
                StreetLine1 = streetLine1,
                StreetLine2 = streetLine2,
                City = city,
                State = state,
                Zip = zip
            };
            string expected = zip;

            // Act
            PeopleSearchService.Models.Address addressServiceModel = databaseAddress.ToAddressServiceModel();
            string actual = addressServiceModel.Zip;

            // Assert
            Assert.AreEqual(expected, actual, string.Format("Database to service model Address Zip failed. \"{0}\" expected, \"{1}\" actual.", expected, actual));
        }

        [TestMethod]
        public void Mapping_DatabasePersonToServiceModel_NullPersonMapsSuccessfully()
        {
            // Arrange
            PeopleSearchDatabase.Models.Person databasePerson = null;

            // Act
            PeopleSearchService.Models.Person actual = databasePerson.ToPersonServiceModel();

            // Assert
            Assert.AreNotEqual(null, actual, "Database to service model Person null test failed.");
        }

        [TestMethod]
        public void Mapping_DatabasePersonToServiceModel_FirstNameMapsSuccessfully()
        {
            // Arrange
            string firstName = "John";
            string lastName = "Doe";
            int age = 44;
            string interests = "Sports, knitting, running, tree climbing, and kayaking.";
            string pictureUrl = "http://www.mytestpictureurl.com/headshot01.jpg";
            PeopleSearchDatabase.Models.Person databasePerson = new PeopleSearchDatabase.Models.Person()
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age,
                Interests = interests,
                PictureUrl = pictureUrl
            };
            string expected = firstName;

            // Act
            PeopleSearchService.Models.Person personServiceModel = databasePerson.ToPersonServiceModel();
            string actual = personServiceModel.FirstName;

            // Assert
            Assert.AreEqual(expected, actual, string.Format("Database to service model Person FirstName failed. \"{0}\" expected, \"{1}\" actual.", expected, actual));
        }

        [TestMethod]
        public void Mapping_DatabasePersonToServiceModel_LastNameMapsSuccessfully()
        {
            // Arrange
            string firstName = "John";
            string lastName = "Doe";
            int age = 44;
            string interests = "Sports, knitting, running, tree climbing, and kayaking.";
            string pictureUrl = "http://www.mytestpictureurl.com/headshot01.jpg";
            PeopleSearchDatabase.Models.Person databasePerson = new PeopleSearchDatabase.Models.Person()
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age,
                Interests = interests,
                PictureUrl = pictureUrl
            };
            string expected = lastName;

            // Act
            PeopleSearchService.Models.Person personServiceModel = databasePerson.ToPersonServiceModel();
            string actual = personServiceModel.LastName;

            // Assert
            Assert.AreEqual(expected, actual, string.Format("Database to service model Person LastName failed. \"{0}\" expected, \"{1}\" actual.", expected, actual));
        }

        [TestMethod]
        public void Mapping_DatabasePersonToServiceModel_AgeMapsSuccessfully()
        {
            // Arrange
            string firstName = "John";
            string lastName = "Doe";
            int age = 44;
            string interests = "Sports, knitting, running, tree climbing, and kayaking.";
            string pictureUrl = "http://www.mytestpictureurl.com/headshot01.jpg";
            PeopleSearchDatabase.Models.Person databasePerson = new PeopleSearchDatabase.Models.Person()
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age,
                Interests = interests,
                PictureUrl = pictureUrl
            };
            int expected = age;

            // Act
            PeopleSearchService.Models.Person personServiceModel = databasePerson.ToPersonServiceModel();
            int actual = personServiceModel.Age;

            // Assert
            Assert.AreEqual(expected, actual, 0, string.Format("Database to service model Person Age failed. \"{0}\" expected, \"{1}\" actual.", expected, actual));
        }

        [TestMethod]
        public void Mapping_DatabasePersonToServiceModel_InterestsMapsSuccessfully()
        {
            // Arrange
            string firstName = "John";
            string lastName = "Doe";
            int age = 44;
            string interests = "Sports, knitting, running, tree climbing, and kayaking.";
            string pictureUrl = "http://www.mytestpictureurl.com/headshot01.jpg";
            PeopleSearchDatabase.Models.Person databasePerson = new PeopleSearchDatabase.Models.Person()
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age,
                Interests = interests,
                PictureUrl = pictureUrl
            };
            string expected = interests;

            // Act
            PeopleSearchService.Models.Person personServiceModel = databasePerson.ToPersonServiceModel();
            string actual = personServiceModel.Interests;

            // Assert
            Assert.AreEqual(expected, actual, string.Format("Database to service model Person Interests failed. \"{0}\" expected, \"{1}\" actual.", expected, actual));
        }

        [TestMethod]
        public void Mapping_DatabasePersonToServiceModel_PictureUrlMapsSuccessfully()
        {
            // Arrange
            string firstName = "John";
            string lastName = "Doe";
            int age = 44;
            string interests = "Sports, knitting, running, tree climbing, and kayaking.";
            string pictureUrl = "http://www.mytestpictureurl.com/headshot01.jpg";
            PeopleSearchDatabase.Models.Person databasePerson = new PeopleSearchDatabase.Models.Person()
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age,
                Interests = interests,
                PictureUrl = pictureUrl
            };
            string expected = pictureUrl;

            // Act
            PeopleSearchService.Models.Person personServiceModel = databasePerson.ToPersonServiceModel();
            string actual = personServiceModel.PictureUrl;

            // Assert
            Assert.AreEqual(expected, actual, string.Format("Database to service model Person PictureUrl failed. \"{0}\" expected, \"{1}\" actual.", expected, actual));
        }

        [TestMethod]
        public void Mapping_DatabasePersonToServiceModel_NullPeopleMapsSuccessfully()
        {
            // Arrange
            List<PeopleSearchDatabase.Models.Person> databasePeople = null;

            // Act
            List<PeopleSearchService.Models.Person> actual = databasePeople.ToPeopleServiceModel();

            // Assert
            Assert.AreNotEqual(null, actual, "Database to service model People null test failed.");
        }
    }
}
