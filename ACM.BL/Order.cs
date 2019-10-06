using System;

namespace ACM.BL
{
    public class Order
    {
        // Constructors
        public Order()
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }


        // Properties
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }


        /// <summary>
        /// Retrieve one order.
        /// </summary>
        public Order Retrieve(int orderId)
        {
            return new Order();
        }


        /// <summary>
        /// Saves the current order.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves the defned order

            return true;
        }


        /// <summary>
        /// Validates the order data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
        
    }
}
