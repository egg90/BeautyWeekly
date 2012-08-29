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
    using System.IO;
    using System.IO.IsolatedStorage;
    using System.Threading;
    using System.Windows;
    using BeautyWeekly.Locators;
    using BeautyWeekly.Models;
    using BeautyWeekly.Services;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using SimpleMvvmToolkit;

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
            ////this.TestAppInfos();
            ////this.TestModels();
            this.TestDumpInternalPackages();
            this.TestLoadInternalPackages();
        }

        #endregion

        #region Notifications

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the categories.
        /// </summary>
        /// <value>
        /// The categories.
        /// </value>
        public List<Category> Categories
        {
            get
            {
                return this.categories;
            }

            set
            {
                this.categories = value;
                NotifyPropertyChanged(m => m.Categories);
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

        #region Methods and Callbacks

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

        /// <summary>
        /// Tests the app infos.
        /// </summary>
        private void TestAppInfos()
        {
            ServiceLocator.Get<ICommonUIService>().ShowMessageBox(ServiceLocator.Get<IApplicationInfoService>().DeviceStatusString, "DeviceStatusString");
            ServiceLocator.Get<ICommonUIService>().ShowMessageBox(ServiceLocator.Get<IApplicationInfoService>().DeviceUniqueId, "DeviceUniqueId");
            ServiceLocator.Get<ICommonUIService>().ShowMessageBox(ServiceLocator.Get<IApplicationInfoService>().OSVersion, "OSVersion");
            ServiceLocator.Get<ICommonUIService>().ShowMessageBox(ServiceLocator.Get<IApplicationInfoService>().VersionNumber, "VersionNumber");
            ServiceLocator.Get<ICommonUIService>().ShowMessageBox(ServiceLocator.Get<IApplicationInfoService>().AppID, "AppID");
            ServiceLocator.Get<ICommonUIService>().ShowMessageBox(ServiceLocator.Get<IApplicationInfoService>().NetworkStatus.ToString("F"), "NetworkStatus");
        }

        /// <summary>
        /// Tests the models.
        /// </summary>
        private void TestModels()
        {
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

            ServiceLocator.Get<IDBManagerService>().InsertOrUpdatePackages(new List<Package> { package, package2 });

            var packages = ServiceLocator.Get<IDBManagerService>().GetPackages();
        }

        /// <summary>
        /// Tests the dump internal packages.
        /// </summary>
        private void TestDumpInternalPackages()
        {
            ////var l = new List<Package>
            ////{
            ////    new Package { Title = "Charm(2012.8.15)", MainPicture = "/Pictures/2-7.jpg", CreateTime = DateTime.Now, Category = "Charm" },
            ////    new Package { Title = "Charm(2012.8.22)", MainPicture = "/Pictures/1-4.png", CreateTime = DateTime.Now, Category = "Charm" },
            ////    new Package { Title = "Charm(2012.8.15)", MainPicture = "/Pictures/2-7.jpg", CreateTime = DateTime.Now, Category = "Pure" },
            ////    new Package { Title = "Charm(2012.8.22)", MainPicture = "/Pictures/1-4.png", CreateTime = DateTime.Now, Category = "Pure" },
            ////};

            var l = new PackageManager().InternalPackages;
            var d = new Dictionary<string, object>();
            d.Add("InternalPackages", l);
            string packages = JsonConvert.SerializeObject(d);

            using (IsolatedStorageFile file = IsolatedStorageFile.GetUserStoreForApplication())
            {
                using (var isoFileStream = new IsolatedStorageFileStream("test.json", System.IO.FileMode.OpenOrCreate, file))
                {
                    using (var writer = new StreamWriter(isoFileStream))
                    {
                        writer.Write(packages);
                    }
                }
            }
        }

        /// <summary>
        /// Tests the load internal packages.
        /// </summary>
        private void TestLoadInternalPackages()
        {
            string jstr;
            using (IsolatedStorageFile file = IsolatedStorageFile.GetUserStoreForApplication())
            {
                using (var isoFileStream = new IsolatedStorageFileStream("test.json", System.IO.FileMode.OpenOrCreate, file))
                {
                    using (var writer = new StreamReader(isoFileStream))
                    {
                        jstr = writer.ReadToEnd();
                    }
                }
            }
            
            var json = JObject.Parse(jstr);
            jstr = json["InternalPackages"].ToString();

            var packages = JsonConvert.DeserializeObject<List<Package>>(jstr);

            var categories = new Dictionary<string, List<Package>>();

            foreach (var package in packages)
            {
                if (categories.ContainsKey(package.Category))
                {
                    categories[package.Category].Add(package);
                }
                else
                {
                    categories.Add(package.Category, new List<Package> { package, });
                }
            }

            List<Category> categoryList = new List<Category>();
            foreach (var pair in categories)
            {
                categoryList.Add(new Category(pair.Key, new List<Package>(pair.Value)));
            }

            this.Categories = categoryList;
        }

        #endregion

        #region Helpers

        #endregion
    }
}
