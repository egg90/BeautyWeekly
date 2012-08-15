//-----------------------------------------------------------------------
// <copyright file="ICustomerServiceAgent.cs" company="Eggfly Corporation">
//     Copyright (c) Xiaomi Corporation. All rights reserved.
// </copyright>
// <author>lihaohua90@gmail.com</author>
//-----------------------------------------------------------------------

namespace BeautyWeekly
{
    using System;
    using System.Linq;

    /// <summary>
    /// ICustomerServiceAgent interface
    /// </summary>
    public interface ICustomerServiceAgent
    {
        /// <summary>
        /// Creates the customer.
        /// </summary>
        /// <returns>Cusomer instance</returns>
        Customer CreateCustomer();
    }
}
