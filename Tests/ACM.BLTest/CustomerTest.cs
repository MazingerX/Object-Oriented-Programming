using System;
using ACM.BL;
using Xunit;

namespace ACM.BLTest
{
    public class CustomerTest
    {
        [Fact]
        public void FullNameTestValid()
        {

            // -- Arrange
            Customer customer = new Customer()
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            string expected = "Baggins, Bilbo";


            // -- Act
            string actual = customer.FullName;

            // -- Assert
            Assert.Equal(expected, actual);

        }
    }
}
