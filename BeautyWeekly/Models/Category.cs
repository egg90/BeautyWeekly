//-----------------------------------------------------------------------
// <copyright file="Category.cs" company="eggfly">
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
    /// PictureGroup Model
    /// </summary>
    public class Category : ModelBase<Category>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Category"/> class.
        /// </summary>
        /// <param name="title">The title.</param>
        /// <param name="pictureGroups">The picture groups.</param>
        public Category(string title, List<PictureGroup> pictureGroups)
        {
            this.Title = title;
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
        /// Gets or sets the picture groups.
        /// </summary>
        /// <value>
        /// The picture groups.
        /// </value>
        public List<PictureGroup> PictureGroups { get; set; }
    }
}
