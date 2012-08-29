//-----------------------------------------------------------------------
// <copyright file="Package.cs" company="eggfly">
//     Copyright (c) eggfly. All rights reserved.
// </copyright>
// <author>eggfly</author>
//-----------------------------------------------------------------------

namespace BeautyWeekly.Models
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Data.Linq.Mapping;
    using System.Linq;
    using SimpleMvvmToolkit;

    /// <summary>
    /// Package Model
    /// </summary>
    [Table]
    public class Package : ModelBase<Package>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Package"/> class.
        /// </summary>
        public Package()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Package"/> class.
        /// </summary>
        /// <param name="title">The title.</param>
        /// <param name="mainPicture">The main picture.</param>
        /// <param name="pictureGroups">The picture groups.</param>
        public Package(string title, string mainPicture, List<PictureGroup> pictureGroups = null)
        {
            this.Title = title;
            this.MainPicture = mainPicture;
            this.PictureGroups = pictureGroups;
        }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>
        /// The id.
        /// </value>
        [Column(IsPrimaryKey = true, IsDbGenerated = true, DbType = "INT NOT NULL Identity", CanBeNull = false, AutoSync = AutoSync.OnInsert)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [Column(CanBeNull = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the main picture.
        /// </summary>
        /// <value>
        /// The main picture.
        /// </value>
        [Column(CanBeNull = true)]
        public string MainPicture { get; set; }

        /// <summary>
        /// Gets or sets the picture groups.
        /// </summary>
        /// <value>
        /// The picture groups.
        /// </value>
        public List<PictureGroup> PictureGroups { get; set; }

        /// <summary>
        /// Gets or sets the create time.
        /// </summary>
        /// <value>
        /// The create time.
        /// </value>
        public DateTime CreateTime { get; set; }
    }
}
