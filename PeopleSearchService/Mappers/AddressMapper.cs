using PeopleSearchService.Models;

namespace PeopleSearchService.Mappers
{
    /// <summary>
    /// Class that contains Address Service mapping functions.
    /// </summary>
    public static class AddressMapper
    {
        /// <summary>
        /// Extension method to map a Database Address Model to the Service Address Model.
        /// </summary>
        /// <param name="databaseAddress">Database Address Model to map from.</param>
        /// <returns>Corresponding Service Address Model</returns>
        public static Address ToAddressServiceModel(this PeopleSearchDatabase.Models.Address databaseAddress)
        {
            Address address = new Address();

            if (databaseAddress != null)
            {
                address.City = databaseAddress.City;
                address.State = databaseAddress.State;
                address.StreetLine1 = databaseAddress.StreetLine1;
                address.StreetLine2 = databaseAddress.StreetLine2;
                address.Zip = databaseAddress.Zip;
            }

            return address;
        }
    }
}
