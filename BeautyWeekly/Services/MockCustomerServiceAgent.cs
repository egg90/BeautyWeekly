//-----------------------------------------------------------------------
// <copyright file="MockCustomerServiceAgent.cs" company="Eggfly Corporation">
//     Copyright (c) Xiaomi Corporation. All rights reserved.
// </copyright>
// <author>lihaohua90@gmail.com</author>
//-----------------------------------------------------------------------

namespace BeautyWeekly
{
    using System;
    using System.Linq;

    /// <summary>
    /// MockCustomerServiceAgent class
    /// </summary>
    public class MockCustomerServiceAgent : ICustomerServiceAgent
    {
        /// <summary>
        /// Creates the customer.
        /// </summary>
        /// <returns>
        /// Cusomer instance
        /// </returns>
        public Customer CreateCustomer()
        {
            return new Customer
            {
                CustomerId = 1,
                CustomerName = "John Doe",
                City = "Dallas"
            };
        }
    }
}
