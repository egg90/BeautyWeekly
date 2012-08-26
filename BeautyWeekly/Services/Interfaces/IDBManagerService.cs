//-----------------------------------------------------------------------
// <copyright file="IDBManagerService.cs" company="eggfly">
//     Copyright (c) eggfly. All rights reserved.
// </copyright>
// <author>eggfly</author>
//-----------------------------------------------------------------------

namespace BeautyWeekly.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows;
    using BeautyWeekly.Models;

    /// <summary>
    /// ICommonUIService Interface
    /// </summary>
    public interface IDBManagerService
    {
        /// <summary>
        /// Gets the packages.
        /// </summary>
        /// <returns>get all packages</returns>
        IList<Package> GetPackages();
    }
}
