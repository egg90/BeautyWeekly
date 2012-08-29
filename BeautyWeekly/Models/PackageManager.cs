﻿//-----------------------------------------------------------------------
// <copyright file="PackageManager.cs" company="eggfly">
//     Copyright (c) eggfly. All rights reserved.
// </copyright>
// <author>eggfly</author>
//-----------------------------------------------------------------------

namespace BeautyWeekly.Models
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Windows;
    using BeautyWeekly.Resources;

    /// <summary>
    /// Package Manager
    /// </summary>
    public class PackageManager
    {
        /// <summary>
        /// Gets the internal packages.
        /// </summary>
        public List<Package> InternalPackages
        {
            get
            {
                var internalPackages = new List<Package>();
                var p = internalPackages;
                p.Add(new Package { Category = AppResources.PureCategory, PackageId = 1, MainPicture = "/Pictures/2-7.jpg", IsInternal = true });
                p.Add(new Package { Category = AppResources.CharmCategory, PackageId = 2, MainPicture = "/Pictures/1-4.jpg", IsInternal = true });
                return internalPackages;
            }
        }
    }
}