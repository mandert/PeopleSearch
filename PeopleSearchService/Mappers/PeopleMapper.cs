using System.Collections.Generic;
using PeopleSearchService.Models;

namespace PeopleSearchService.Mappers
{
    /// <summary>
    /// Class that contains People/Person Service mapping functions.
    /// </summary>
    public static class PeopleMapper
    {
        /// <summary>
        /// Extension method to map multiple Database Person Models to the Service Person Models.
        /// </summary>
        /// <param name="databasePeople">Database People Model to map from.</param>
        /// <returns>Corresponding Service People Model</returns>
        public static List<Person> ToPeopleServiceModel(this List<PeopleSearchDatabase.Models.Person> databasePeople)
        {
            List<Person> people = new List<Person>();

            if (databasePeople != null)
            {
                foreach (PeopleSearchDatabase.Models.Person databasePerson in databasePeople)
                {
                    people.Add(databasePerson.ToPersonServiceModel());
                }    
            }

            return people;
        }

        /// <summary>
        /// Extension method to map a Database Person Model to the Service Person Model.
        /// </summary>
        /// <param name="databasePerson">Database Person Model to map from.</param>
        /// <returns>Corresponding Service Person Model</returns>
        public static Person ToPersonServiceModel(this PeopleSearchDatabase.Models.Person databasePerson)
        {
            Person person = new Person();

            if (databasePerson != null)
            {
                person.Address = databasePerson.Address.ToAddressServiceModel();
                person.Age = databasePerson.Age;
                person.FirstName = databasePerson.FirstName;
                person.Interests = databasePerson.Interests;
                person.LastName = databasePerson.LastName;
                person.PictureUrl = databasePerson.PictureUrl;
            }

            return person;
        }
    }
}
