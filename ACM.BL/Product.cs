using System;

namespace ACM.BL
{
    public class Product
    {
        //Constructors

        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }


        // Properties

        public int ProductId { get; private set; }

        public string ProductDescription { get; set; }

        public decimal? CurrentPrice { get; set; }

        public string ProductName { get; set; }
      

        /// <summary>
        /// Validates the product data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

    }
}
