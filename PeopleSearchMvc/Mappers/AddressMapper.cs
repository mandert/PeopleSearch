using PeopleSearch.Models;

namespace PeopleSearch.Mappers
{
    /// <summary>
    /// Class that contains Address ViewModel mapping functions.
    /// </summary>
    public static class AddressMapper
    {
        /// <summary>
        /// Extension method to map a Service Address Model to the View Address Model.
        /// </summary>
        /// <param name="serviceAddress">Service Address Model to map from.</param>
        /// <returns>Corresponding View Address Model</returns>
        public static Address ToAddressViewModel(this PeopleSearchService.Models.Address serviceAddress)
        {
            Address address = new Address();

            if (serviceAddress != null)
            {
                address.City = serviceAddress.City;
                address.State = serviceAddress.State;
                address.StreetLine1 = serviceAddress.StreetLine1;
                address.StreetLine2 = serviceAddress.StreetLine2;
                address.Zip = serviceAddress.Zip;
            }

            return address;
        }
    }
}