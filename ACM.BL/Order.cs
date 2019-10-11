using System;
using System.Collections.Generic;
using Acme.Common;

namespace ACM.BL
{
    public class Order : EntityBase, ILoggable
    {
        // Constructors
        public Order() : this(0)
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }


        // Properties
        public int CustomerId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }
        public List<OrderItem> OrderItems { get; set; }
        public int ShippingAddressId { get; set; }

        public string Log()
        {
            throw new NotImplementedException();
        }

        public override string ToString() => $"{OrderDate.Value.Date} ({OrderId})";

        /// <summary>
        /// Validates the order data.
        /// </summary>
        /// <returns></returns>
        /*public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }*/

        public override bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}
