﻿//-----------------------------------------------------------------------
// <copyright file="ICustomerServiceAgent.cs" company="eggfly">
//     Copyright (c) eggfly. All rights reserved.
// </copyright>
// <author>eggfly</author>
//-----------------------------------------------------------------------

namespace BeautyWeekly.Services
{
    using System;
    using System.Linq;
    using BeautyWeekly.Models;

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
