using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeopleSearch.Mappers;

namespace PeopleSearchTests.Tests
{
    /// <summary>
    /// Test Cases for the PeopleSearchMvc Project
    /// </summary>
    [TestClass]
    public class PeopleSearchMvcTests
    {
        [TestMethod]
        public void Mapping_ServiceAddressToViewModel_NullAddressMapsSuccessfully()
        {
            // Arrange
            PeopleSearchService.Models.Address serviceAddress = null;

            // Act
            PeopleSearch.Models.Address actual = serviceAddress.ToAddressViewModel();

            // Assert
            Assert.AreNotEqual(null, actual, "Service to view model Address null test failed.");
        }

        [TestMethod]
        public void Mapping_ServiceAddressToViewModel_StreetLine1MapsSuccessfully()
        {
            // Arrange
            string streetLine1 = "123 State St";
            string streetLine2 = "Apt 456";
            string city = "Minneapolis";
            string state = "MN";
            string zip = "55401";
            PeopleSearchService.Models.Address serviceAddress = new PeopleSearchService.Models.Address()
            {
                StreetLine1 = streetLine1,
                StreetLine2 = streetLine2,
                City = city,
                State = state,
                Zip = zip
            };
            string expected = streetLine1;

            // Act
            PeopleSearch.Models.Address addressViewModel = serviceAddress.ToAddressViewModel();
            string actual = addressViewModel.StreetLine1;

            // Assert
            Assert.AreEqual(expected, actual, string.Format("Service to view model Address StreetLine1 failed. \"{0}\" expected, \"{1}\" actual.", expected, actual));
        }

        [TestMethod]
        public void Mapping_ServiceAddressToViewModel_StreetLine2MapsSuccessfully()
        {
            // Arrange
            string streetLine1 = "123 State St";
            string streetLine2 = "Apt 456";
            string city = "Minneapolis";
            string state = "MN";
            string zip = "55401";
            PeopleSearchService.Models.Address serviceAddress = new PeopleSearchService.Models.Address()
            {
                StreetLine1 = streetLine1,
                StreetLine2 = streetLine2,
                City = city,
                State = state,
                Zip = zip
            };
            string expected = streetLine2;

            // Act
            PeopleSearch.Models.Address addressViewModel = serviceAddress.ToAddressViewModel();
            string actual = addressViewModel.StreetLine2;

            // Assert
            Assert.AreEqual(expected, actual, string.Format("Service to view model Address StreetLine2 failed. \"{0}\" expected, \"{1}\" actual.", expected, actual));
        }

        [TestMethod]
        public void Mapping_ServiceAddressToViewModel_CityMapsSuccessfully()
        {
            // Arrange
            string streetLine1 = "123 State St";
            string streetLine2 = "Apt 456";
            string city = "Minneapolis";
            string state = "MN";
            string zip = "55401";
            PeopleSearchService.Models.Address serviceAddress = new PeopleSearchService.Models.Address()
            {
                StreetLine1 = streetLine1,
                StreetLine2 = streetLine2,
                City = city,
                State = state,
                Zip = zip
            };
            string expected = city;

            // Act
            PeopleSearch.Models.Address addressViewModel = serviceAddress.ToAddressViewModel();
            string actual = addressViewModel.City;

            // Assert
            Assert.AreEqual(expected, actual, string.Format("Service to view model Address City failed. \"{0}\" expected, \"{1}\" actual.", expected, actual));
        }

        [TestMethod]
        public void Mapping_ServiceAddressToViewModel_StateMapsSuccessfully()
        {
            // Arrange
            string streetLine1 = "123 State St";
            string streetLine2 = "Apt 456";
            string city = "Minneapolis";
            string state = "MN";
            string zip = "55401";
            PeopleSearchService.Models.Address serviceAddress = new PeopleSearchService.Models.Address()
            {
                StreetLine1 = streetLine1,
                StreetLine2 = streetLine2,
                City = city,
                State = state,
                Zip = zip
            };
            string expected = state;

            // Act
            PeopleSearch.Models.Address addressViewModel = serviceAddress.ToAddressViewModel();
            string actual = addressViewModel.State;

            // Assert
            Assert.AreEqual(expected, actual, string.Format("Service to view model Address State failed. \"{0}\" expected, \"{1}\" actual.", expected, actual));
        }

        [TestMethod]
        public void Mapping_ServiceAddressToViewModel_ZipMapsSuccessfully()
        {
            // Arrange
            string streetLine1 = "123 State St";
            string streetLine2 = "Apt 456";
            string city = "Minneapolis";
            string state = "MN";
            string zip = "55401";
            PeopleSearchService.Models.Address serviceAddress = new PeopleSearchService.Models.Address()
            {
                StreetLine1 = streetLine1,
                StreetLine2 = streetLine2,
                City = city,
                State = state,
                Zip = zip
            };
            string expected = zip;

            // Act
            PeopleSearch.Models.Address addressViewModel = serviceAddress.ToAddressViewModel();
            string actual = addressViewModel.Zip;

            // Assert
            Assert.AreEqual(expected, actual, string.Format("Service to view model Address Zip failed. \"{0}\" expected, \"{1}\" actual.", expected, actual));
        }

        [TestMethod]
        public void Mapping_ServicePersonToViewModel_NullPersonMapsSuccessfully()
        {
            // Arrange
            PeopleSearchService.Models.Person servicePerson = null;

            // Act
            PeopleSearch.Models.Person actual = servicePerson.ToPersonViewModel();

            // Assert
            Assert.AreNotEqual(null, actual, "Service to view model Person null test failed.");
        }

        [TestMethod]
        public void Mapping_ServicePersonToViewModel_FirstNameMapsSuccessfully()
        {
            // Arrange
            string firstName = "John";
            string lastName = "Doe";
            int age = 44;
            string interests = "Sports, knitting, running, tree climbing, and kayaking.";
            string pictureUrl = "http://www.mytestpictureurl.com/headshot01.jpg";
            PeopleSearchService.Models.Person servicePerson = new PeopleSearchService.Models.Person()
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age,
                Interests = interests,
                PictureUrl = pictureUrl
            };
            string expected = firstName;

            // Act
            PeopleSearch.Models.Person personViewModel = servicePerson.ToPersonViewModel();
            string actual = personViewModel.FirstName;

            // Assert
            Assert.AreEqual(expected, actual, string.Format("Service to view model Person FirstName failed. \"{0}\" expected, \"{1}\" actual.", expected, actual));
        }

        [TestMethod]
        public void Mapping_ServicePersonToViewModel_LastNameMapsSuccessfully()
        {
            // Arrange
            string firstName = "John";
            string lastName = "Doe";
            int age = 44;
            string interests = "Sports, knitting, running, tree climbing, and kayaking.";
            string pictureUrl = "http://www.mytestpictureurl.com/headshot01.jpg";
            PeopleSearchService.Models.Person servicePerson = new PeopleSearchService.Models.Person()
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age,
                Interests = interests,
                PictureUrl = pictureUrl
            };
            string expected = lastName;

            // Act
            PeopleSearch.Models.Person personViewModel = servicePerson.ToPersonViewModel();
            string actual = personViewModel.LastName;

            // Assert
            Assert.AreEqual(expected, actual, string.Format("Service to view model Person LastName failed. \"{0}\" expected, \"{1}\" actual.", expected, actual));
        }

        [TestMethod]
        public void Mapping_ServicePersonToViewModel_AgeMapsSuccessfully()
        {
            // Arrange
            string firstName = "John";
            string lastName = "Doe";
            int age = 44;
            string interests = "Sports, knitting, running, tree climbing, and kayaking.";
            string pictureUrl = "http://www.mytestpictureurl.com/headshot01.jpg";
            PeopleSearchService.Models.Person servicePerson = new PeopleSearchService.Models.Person()
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age,
                Interests = interests,
                PictureUrl = pictureUrl
            };
            int expected = age;

            // Act
            PeopleSearch.Models.Person personViewModel = servicePerson.ToPersonViewModel();
            int actual = personViewModel.Age;

            // Assert
            Assert.AreEqual(expected, actual, 0, string.Format("Service to view model Person Age failed. \"{0}\" expected, \"{1}\" actual.", expected, actual));
        }

        [TestMethod]
        public void Mapping_ServicePersonToViewModel_InterestsMapsSuccessfully()
        {
            // Arrange
            string firstName = "John";
            string lastName = "Doe";
            int age = 44;
            string interests = "Sports, knitting, running, tree climbing, and kayaking.";
            string pictureUrl = "http://www.mytestpictureurl.com/headshot01.jpg";
            PeopleSearchService.Models.Person servicePerson = new PeopleSearchService.Models.Person()
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age,
                Interests = interests,
                PictureUrl = pictureUrl
            };
            string expected = interests;

            // Act
            PeopleSearch.Models.Person personViewModel = servicePerson.ToPersonViewModel();
            string actual = personViewModel.Interests;

            // Assert
            Assert.AreEqual(expected, actual, string.Format("Service to view model Person Interests failed. \"{0}\" expected, \"{1}\" actual.", expected, actual));
        }

        [TestMethod]
        public void Mapping_ServicePersonToViewModel_PictureUrlMapsSuccessfully()
        {
            // Arrange
            string firstName = "John";
            string lastName = "Doe";
            int age = 44;
            string interests = "Sports, knitting, running, tree climbing, and kayaking.";
            string pictureUrl = "http://www.mytestpictureurl.com/headshot01.jpg";
            PeopleSearchService.Models.Person servicePerson = new PeopleSearchService.Models.Person()
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age,
                Interests = interests,
                PictureUrl = pictureUrl
            };
            string expected = pictureUrl;

            // Act
            PeopleSearch.Models.Person personViewModel = servicePerson.ToPersonViewModel();
            string actual = personViewModel.PictureUrl;

            // Assert
            Assert.AreEqual(expected, actual, string.Format("Service to view model Person PictureUrl failed. \"{0}\" expected, \"{1}\" actual.", expected, actual));
        }

        [TestMethod]
        public void Mapping_ServicePeopleToViewModel_NullPeopleMapsSuccessfully()
        {
            // Arrange
            List<PeopleSearchService.Models.Person> servicePeople = null;

            // Act
            List<PeopleSearch.Models.Person> actual = servicePeople.ToPeopleViewModel();

            // Assert
            Assert.AreNotEqual(null, actual, "Service to view model People null test failed.");
        }

        [TestMethod]
        public void Mapping_ServiceSearchResultsToViewModel_ResultsFoundMapsSuccessfully()
        {
            // Arrange
            int resultsFound = 76;
            PeopleSearchService.Models.SearchResults serviceSearchResults = new PeopleSearchService.Models.SearchResults()
            {
                ResultsFound = resultsFound
            };
            int expected = resultsFound;

            // Act
            PeopleSearch.Models.SearchForPeopleResponse searchForPeopleResponseViewModel =
                serviceSearchResults.ToSearchForPeopleResponseViewModel();
            int actual = searchForPeopleResponseViewModel.ResultsFound;

            // Assert
            Assert.AreEqual(expected, actual, 0, string.Format("Service to view model SearchResults ResultsFound failed. \"{0}\" expected, \"{1}\" actual.", expected, actual));
        }
    }
}
