//-----------------------------------------------------------------------
// <copyright file="MainViewModel.cs" company="Eggfly Corporation">
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
    /// MainViewModel class
    /// </summary>
    public class MainViewModel : ViewModelBase<MainViewModel>
    {
        /// <summary>
        /// list items
        /// </summary>
        private List<string> listItems = new List<string>
        {
            "/Pictures/01.png",
            "/Pictures/02.png",
        };

        #region Initialization and Cleanup

        /// <summary>
        /// Initializes a new instance of the <see cref="MainViewModel"/> class.
        /// </summary>
        public MainViewModel()
        {
        }

        #endregion

        #region Notifications

        #endregion

        #region Properties

        /// <summary>
        /// Gets the photos.
        /// </summary>
        public List<string> ListItems
        {
            get
            {
                return this.listItems;
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
            MessageBox.Show("OnAppBarLikeButtonClick");
        }

        /// <summary>
        /// Called when [app bar about menu click].
        /// </summary>
        public void OnAppBarAboutMenuClick()
        {
            MessageBox.Show("OnAppBarAboutMenuClick");
        }

        #endregion

        #region Helpers

        #endregion
    }
}
