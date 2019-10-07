using System;
using ACM.BL;
using Xunit;

namespace ACM.BLTest
{
    public class ProductRepositoryTest
    {
        [Fact]
        public void RetrieveTest()
        {

            // -- Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                ProductName = "Sunflowers",
                ProductDescription = "Assorted size set of 4 yellow",
                CurrentPrice = 15.96M
            };

            // -- Act
            var actual = productRepository.Retrieve(2);

            // -- Assert
            Assert.Equal(expected.ProductName, actual.ProductName);
            Assert.Equal(expected.ProductDescription, actual.ProductDescription);
            Assert.Equal(expected.CurrentPrice, actual.CurrentPrice);
        }


        [Fact]
        public void SaveTestValid()
        {

            // -- Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                HasChanges = true,
                ProductName = "Sunflowers",
                ProductDescription = "Assorted size set of 4 yellow",
                CurrentPrice = 18M
            };

            // -- Act
            var actual = productRepository.Save(updatedProduct);

            // -- Assert
            Assert.Equal(true, actual);

        }


        [Fact]
        public void SaveTestMissingPrice()
        {

            // -- Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                HasChanges = true,
                ProductName = "Sunflowers",
                ProductDescription = "Assorted size set of 4 yellow",
                CurrentPrice = null
            };

            // -- Act
            var actual = productRepository.Save(updatedProduct);

            // -- Assert
            Assert.Equal(false, actual);

        }
    }
}
