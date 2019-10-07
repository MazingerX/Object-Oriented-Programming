using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class AddressRepository
    {
        /// <summary>
        /// Retrieve one address
        /// </summary>
        public Address Retrieve(int addressId)
        {
            // Create the instance of the Address class
            // Pass in the rquest Id

            Address address = new Address(addressId);

            // Code that retireves the defined address.

            //Temporary hard-coded values to return
            // a populated address

            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot row";
                address.City = "Hobbiton";
                address.StatePublic = "Shine";
                address.Country = "Middle Earth";
                address.PostalCode = "144";
            }
            return address;
        }


        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            // Code that retrieves the defined address
            // for the customer.

            // Temporary hard-coded values to return
            // a set of addresses for a customer

            var addressList = new List<Address>();

            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bag End",
                StreetLine2 = "Bagshot row",
                City = "Hobbiton",
                StatePublic = "Shine",
                Country = "Middle Earth",
                PostalCode = "144"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Green Dragon",
                StreetLine2 = "Bywater",
                City = "Shire",
                StatePublic = "Shine",
                Country = "Middle Earth",
                PostalCode = "146"
            };
            addressList.Add(address);

            return addressList;
        }


        /// <summary>
        /// Saves the current address.
        /// </summary>
        /// <return></return>
        public bool Save()
        {
            // Code that saves the passed in address.
            return true;
        }
    }
}
