//-----------------------------------------------------------------------
// <copyright file="PictureGroup.cs" company="Eggfly Corporation">
//     Copyright (c) Eggfly Corporation. All rights reserved.
// </copyright>
// <author>lihaohua90@gmail.com</author>
//-----------------------------------------------------------------------

namespace BeautyWeekly
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
