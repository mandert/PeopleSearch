using PeopleSearch.Models;
using System.Collections.Generic;

namespace PeopleSearch.Mappers
{
    /// <summary>
    /// Class that contains People/Person ViewModel mapping functions.
    /// </summary>
    public static class PeopleMapper
    {
        /// <summary>
        /// Extension method to map multiple Service Person Models to the View Person Models.
        /// </summary>
        /// <param name="servicePeople">Service People Model to map from.</param>
        /// <returns>Corresponding View People Model</returns>
        public static List<Person> ToPeopleViewModel(this List<PeopleSearchService.Models.Person> servicePeople)
        {
            List<Person> peopleViewModel = new List<Person>();

            if (servicePeople != null)
            {
                foreach (PeopleSearchService.Models.Person servicePerson in servicePeople)
                {
                    peopleViewModel.Add(servicePerson.ToPersonViewModel());
                }    
            }

            return peopleViewModel;
        }

        /// <summary>
        /// Extension method to map a Service Person Model to the View Person Model.
        /// </summary>
        /// <param name="servicePerson">Service Person Model to map from.</param>
        /// <returns>Corresponding View Person Model</returns>
        public static Person ToPersonViewModel(this PeopleSearchService.Models.Person servicePerson)
        {
            Person person = new Person();

            if (servicePerson != null)
            {
                person.Address = servicePerson.Address.ToAddressViewModel();
                person.Age = servicePerson.Age;
                person.FirstName = servicePerson.FirstName;
                person.Interests = servicePerson.Interests;
                person.LastName = servicePerson.LastName;
                person.PictureUrl = servicePerson.PictureUrl;
            }

            return person;
        }
    }
}