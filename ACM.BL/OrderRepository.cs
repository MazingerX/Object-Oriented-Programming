﻿using System;

namespace ACM.BL
{
    public class OrderRepository
    {
       /// <summary>
       /// Retrieve one order
       /// </summary>
       public Order Retrieve(int orderId)
        {
            // Creates the instance of the Order class
            // Pass in the requested Id

            Order order = new Order(orderId);

            //Code that retrieves the defined order

            // Temporary hard-coded values to return
            // a populated order
            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00,
                    new TimeSpan(7, 0, 0));
            }

            return order;
        }


        /// <summary>
        /// Saves the current order
        /// </summary>
        public bool Saves()
        {
            // Code that saves the passed in order

            return true;
        }
    }
}
