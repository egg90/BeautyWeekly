//-----------------------------------------------------------------------
// <copyright file="PictureGroup.cs" company="eggfly">
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
    public class PictureGroup : ModelBase<PictureGroup>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PictureGroup"/> class.
        /// </summary>
        /// <param name="title">The title.</param>
        /// <param name="mainPicture">The main picture.</param>
        public PictureGroup(string title, string mainPicture)
        {
            this.Title = title;
            this.MainPicture = mainPicture;
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
        /// Gets or sets the picture list.
        /// </summary>
        /// <value>
        /// The picture list.
        /// </value>
        public ObservableCollection<string> PictureList { get; set; }
    }
}
