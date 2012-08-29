//-----------------------------------------------------------------------
// <copyright file="DBManagerService.cs" company="eggfly">
//     Copyright (c) eggfly. All rights reserved.
// </copyright>
// <author>eggfly</author>
//-----------------------------------------------------------------------

namespace BeautyWeekly.Services
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data.Linq;
    using System.Linq;
    using System.Windows;
    using BeautyWeekly.Models;

    /// <summary>
    /// DBManager Service
    /// </summary>
    public class DBManagerService : IDBManagerService
    {
        /// <summary>
        /// data conext lock
        /// </summary>
        private object dataContextLock = new object();

        /// <summary>
        /// Initializes a new instance of the <see cref="DBManagerService"/> class.
        /// </summary>
        public DBManagerService()
        {
        }

        /// <summary>
        /// Gets the packages.
        /// </summary>
        /// <returns>
        /// get all packages
        /// </returns>
        public IList<Package> GetPackages()
        {
            lock (this.dataContextLock)
            {
                this.CreateDBIfNotExist();
                using (var dataContext = new DBContext())
                {
                    Table<Package> table = dataContext.Packages;
                    return table.ToList();
                }
            }
        }

        /// <summary>
        /// Creates the DB if not exist.
        /// </summary>
        private void CreateDBIfNotExist()
        {
            lock (this.dataContextLock)
            {
                using (var dataContext = new DBContext())
                {
                    if (!dataContext.DatabaseExists())
                    {
                        dataContext.CreateDatabase();
                    }
                }
            }
        }
    }
}
