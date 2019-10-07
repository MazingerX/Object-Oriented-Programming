using System;

namespace ACM.BL
{
    public class ProductRepository
    {
        /// <summary>
        /// Retrieve one product.
        /// </summary>
        public Product Retrieve(int productId)
        {
            // Create the instance of the Product class
            // Pass in the requested Id
            Product product = new Product(productId);

            // Code that retrieves the defined product

            // Temporary hard-coded values to return
            // a populated product
            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted size set of 4 yellow";
                product.CurrentPrice = 15.96M;
            }

            Object myObject = new object();
            Console.WriteLine($"Object: {myObject.ToString()}");
            Console.WriteLine($"Product: {product.ToString()}");
            return product;
        }


        /// <summary>
        /// Saves the current product.
        /// </summary>
        /// <returns></returns>
        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        // Call a Insert Store Procedure
                    }
                    else
                    {
                        // Call an Update Store Procedure
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
