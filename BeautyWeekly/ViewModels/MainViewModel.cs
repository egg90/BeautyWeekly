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
    using Newtonsoft.Json;
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

            string json;

            //// picture group
            PictureGroup pictureGroup = new PictureGroup { Title = "组图", MainPicture = "主图像url" };
            pictureGroup.PictureList = new List<string> { "url1", "url2" };
            
            json = JsonConvert.SerializeObject(pictureGroup);
            PictureGroup group = JsonConvert.DeserializeObject<PictureGroup>(json);

            //// package
            Package package = this.categories[0].Packages[0];
            package.Category = string.Empty;
            package.CreateTime = DateTime.Now;
            package.PictureGroups = new List<PictureGroup> { pictureGroup, pictureGroup, };

            json = JsonConvert.SerializeObject(package);
            Package package2 = JsonConvert.DeserializeObject<Package>(json);

            ServiceLocator.Get<IDBManagerService>().InsertOrUpdatePackage(package2);
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
        /// Gets the package list tap command.
        /// </summary>
        public DelegateCommand<Package> PackageListTapCommand
        {
            get
            {
                return this.packageListTapCommand ?? (this.packageListTapCommand = new DelegateCommand<Package>(this.OnPackageListBoxTap));
            }
        }

        #endregion

        #region Methods

        #endregion

        #region Callbacks

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
