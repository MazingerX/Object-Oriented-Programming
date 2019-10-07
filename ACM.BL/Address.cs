using System;
namespace ACM.BL
{
    public class Address
    {
        public Address()
        {

        }

        public Address(int addressId)
        {
            AddressId = addressId;
        }


        // Properties
        public int AddressId { get; private set; }
        public int AddressType { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string City { get; set; }
        public string StatePublic { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }


        /// <sumary>
        /// Validates the address
        /// </sumary>
        public bool Validate()
        {
            var isValid = true;

            if (PostalCode == null) isValid = false;

            return isValid;
        }
    }
}
