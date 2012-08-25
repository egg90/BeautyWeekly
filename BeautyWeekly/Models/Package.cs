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
    using System.Linq;
    using SimpleMvvmToolkit;

    /// <summary>
    /// Package Model
    /// </summary>
    public class Package : ModelBase<Package>
    {
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
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the main picture.
        /// </summary>
        /// <value>
        /// The main picture.
        /// </value>
        public string MainPicture { get; set; }

        /// <summary>
        /// Gets or sets the picture groups.
        /// </summary>
        /// <value>
        /// The picture groups.
        /// </value>
        public List<PictureGroup> PictureGroups { get; set; }
    }
}
