//-----------------------------------------------------------------------
// <copyright file="ViewPicturePageViewModel.cs" company="Eggfly Corporation">
//     Copyright (c) Eggfly Corporation. All rights reserved.
// </copyright>
// <author>lihaohua90@gmail.com</author>
//-----------------------------------------------------------------------

namespace BeautyWeekly
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Threading;
    using System.Windows;
    using SimpleMvvmToolkit;
    using SimpleMvvmToolkit.ModelExtensions;

    /// <summary>
    /// ViewPicturePageViewModel class
    /// </summary>
    public class ViewPicturePageViewModel : ViewModelBase<MainPageViewModel>
    {
        /// <summary>
        /// photo strings
        /// </summary>
        private List<string> photos = new List<string> { "/Pictures/1.jpg", "/Pictures/2.jpg" };

        #region Initialization and Cleanup

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewPicturePageViewModel"/> class.
        /// </summary>
        public ViewPicturePageViewModel()
        {
        }

        #endregion

        #region Notifications

        #endregion

        #region Properties

        /// <summary>
        /// Gets the photos.
        /// </summary>
        public List<string> Photos
        {
            get
            {
                return this.photos;
            }
        }

        #endregion

        #region Methods

        #endregion

        #region Callbacks

        /// <summary>
        /// Called when [app bar like button click].
        /// </summary>
        public void OnAppBarLikeButtonClick()
        {
            MessageBox.Show("okok");
        }

        #endregion

        #region Helpers

        #endregion
    }
}
