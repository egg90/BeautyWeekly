//-----------------------------------------------------------------------
// <copyright file="MainViewModel.cs" company="eggfly">
//     Copyright (c) eggfly. All rights reserved.
// </copyright>
// <author>eggfly</author>
//-----------------------------------------------------------------------

namespace BeautyWeekly.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Threading;
    using System.Windows;
    using BeautyWeekly.Locators;
    using BeautyWeekly.Models;
    using BeautyWeekly.Services;
    using SimpleMvvmToolkit;
    using SimpleMvvmToolkit.ModelExtensions;

    /// <summary>
    /// MainViewModel class
    /// </summary>
    public class MainViewModel : ViewModelBase<MainViewModel>
    {
        /// <summary>
        /// the categories
        /// </summary>
        private List<Category> categories = new List<Category>
        {
            new Category(
                "魅惑写真",
                new List<Package>
                {
                    new Package("魅惑写真(2012.8.15)", "/Pictures/2-7.jpg"),
                    new Package("魅惑写真(2012.8.22)", "/Pictures/1-4.png"),
                }),

            new Category(
                "清纯私房",
                new List<Package>
                {
                    new Package("清纯私房(2012.8.15)", "/Pictures/1-4.png"),
                    new Package("清纯私房(2012.8.22)", "/Pictures/2-7.jpg"),
                }),
        };

        /// <summary>
        /// the package list tap command
        /// </summary>
        private DelegateCommand<Package> packageListTapCommand;

        #region Initialization and Cleanup

        /// <summary>
        /// Initializes a new instance of the <see cref="MainViewModel"/> class.
        /// </summary>
        public MainViewModel()
        {
            ////ServiceLocator.Resolve<ICommonUIService>().ShowMessageBox(ServiceLocator.Resolve<IApplicationInfoService>().DeviceStatusString, "DeviceStatusString");
            ////ServiceLocator.Resolve<ICommonUIService>().ShowMessageBox(ServiceLocator.Resolve<IApplicationInfoService>().DeviceUniqueId, "DeviceUniqueId");
            ////ServiceLocator.Resolve<ICommonUIService>().ShowMessageBox(ServiceLocator.Resolve<IApplicationInfoService>().OSVersion, "OSVersion");
            ////ServiceLocator.Resolve<ICommonUIService>().ShowMessageBox(ServiceLocator.Resolve<IApplicationInfoService>().VersionNumber, "VersionNumber");
            ////ServiceLocator.Resolve<ICommonUIService>().ShowMessageBox(ServiceLocator.Resolve<IApplicationInfoService>().AppID, "AppID");
            ////ServiceLocator.Resolve<ICommonUIService>().ShowMessageBox(ServiceLocator.Resolve<IApplicationInfoService>().NetworkStatus.ToString("F"), "NetworkStatus");
            IList<Package> packages = ServiceLocator.Get<IDBManagerService>().GetPackages();
        }

        #endregion

        #region Notifications

        #endregion

        #region Properties

        /// <summary>
        /// Gets the photos.
        /// </summary>
        public List<Category> Categories
        {
            get
            {
                return this.categories;
            }
        }

        /// <summary>
        /// Gets or sets the Conversation ListTap command.
        /// </summary>
        /// <value>
        /// The Conversation ListTap command.
        /// </value>
        public DelegateCommand<Package> PackageListTapCommand
        {
            get
            {
                return this.packageListTapCommand ?? (this.packageListTapCommand = new DelegateCommand<Package>(this.OnPackageListBoxTap));
            }

            set
            {
                this.packageListTapCommand = value;
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

        /// <summary>
        /// Called when [package list box tap].
        /// </summary>
        /// <param name="args">The args.</param>
        public void OnPackageListBoxTap(Package args)
        {
            //// ServiceLocator.Get<ICommonUIService>().ShowMessageBox(args.ToString(), "title");
            string target = string.Format("/Views/ViewPackagePage.xaml?id={0}", 0);
            ServiceLocator.Get<INavigator>().NavigateTo(target);
        }

        #endregion

        #region Helpers

        #endregion
    }
}
