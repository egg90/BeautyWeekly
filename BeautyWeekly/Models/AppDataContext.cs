//-----------------------------------------------------------------------
// <copyright file="AppDataContext.cs" company="eggfly">
//     Copyright (c) eggfly. All rights reserved.
// </copyright>
// <author>eggfly</author>
//-----------------------------------------------------------------------

namespace BeautyWeekly.Models
{
    using System;
    using System.Data.Linq;

    /// <summary>
    /// App DataContext
    /// </summary>
    public class AppDataContext : DataContext
    {
        /// <summary>
        /// database connection string
        /// </summary>
        public const string DBConnectionString = "Data Source=isostore:/Database.sdf";

        /// <summary>
        /// Initializes a new instance of the <see cref="AppDataContext"/> class.
        /// </summary>
        public AppDataContext()
            : base(DBConnectionString)
        {
        }

        /// <summary>
        /// Gets the packages.
        /// </summary>
        public Table<Package> Packages
        {
            get
            {
                return this.GetTable<Package>();
            }
        }
    }
}
