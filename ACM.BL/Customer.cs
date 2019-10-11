﻿using System;
using System.Collections.Generic;
using Acme.Common;

namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable
    {
        // Constructors
        public Customer(): this(0)
        {

        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }


        // Properties
        public List<Address> AddressList { get; set;}

        public int CustomerId { get; private set; }

        public int CustomerType { get; set; }

        public string EmailAddress { get; set; }

        public string FirstName { get; set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                        {
                        fullName += ", ";
                        }
                fullName += FirstName;
                }
                return fullName;
            }
        }

        public static int InstanceCount { get; set; }

        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }


        //public string Log()
        //{
        // var logString = CustomerId + ": " + Fullname + " " + "Email: " +
        //                 EmailAddress + " " + "Status: " + EntityState.ToString();
        // return logString;


        public string Log() =>
            $"{CustomerId}: {FullName} Email: {EmailAddress} Status: {EntityState.ToString()}";


        public override string ToString() => FullName;

        /// <summary>
        /// Validates the customer data
        /// </summary>
        /// <returns></returns>
        /*public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }*/

        public override bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}
