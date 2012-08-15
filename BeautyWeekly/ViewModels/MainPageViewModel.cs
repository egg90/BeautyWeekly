using System;
using System.Windows;
using System.Threading;
using System.Collections.ObjectModel;

// Toolkit namespace
using SimpleMvvmToolkit;

// Toolkit extension methods
using SimpleMvvmToolkit.ModelExtensions;

namespace BeautyWeekly
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// Use the <strong>mvvmprop</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// </summary>
    public class MainPageViewModel : ViewModelBase<MainPageViewModel>
    {
        #region Initialization and Cleanup

        // Default ctor
        public MainPageViewModel() { }

        #endregion

        #region Notifications

        // Add events to notify the view or obtain data from the view
        public event EventHandler<NotificationEventArgs<Exception>> ErrorNotice;

        #endregion

        #region Properties

        private string appTitle = "Simple MVVM Toolkit for WP7";
        public string AppTitle
        {
            get
            {
                if (IsInDesignMode) return "Application Title";
                return appTitle;
            }
            set
            {
                appTitle = value;
                NotifyPropertyChanged(m => m.AppTitle);
            }
        }

        // Add Header property using the mvvmprop code snippet
        private string pageTitle = "hello mvvm";
        public string PageTitle
        {
            get
            {
                if (IsInDesignMode) return "page title";
                return pageTitle;
            }
            set
            {
                pageTitle = value;
                NotifyPropertyChanged(m => m.PageTitle);
            }
        }

        #endregion

        #region Methods

        #endregion

        #region Completion Callbacks

        #endregion

        #region Helpers

        // Helper method to notify View of an error
        private void NotifyError(string message, Exception error)
        {
            // Notify view of an error
            Notify(ErrorNotice, new NotificationEventArgs<Exception>(message, error));
        }

        #endregion
    }
}