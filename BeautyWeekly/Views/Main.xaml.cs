//-----------------------------------------------------------------------
// <copyright file="Main.xaml.cs" company="Eggfly Corporation">
//     Copyright (c) Eggfly Corporation. All rights reserved.
// </copyright>
// <author>lihaohua90@gmail.com</author>
//-----------------------------------------------------------------------

namespace BeautyWeekly.Views
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Documents;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Animation;
    using System.Windows.Shapes;
    using Microsoft.Phone.Controls;

    /// <summary>
    /// main page class
    /// </summary>
    public partial class Main : PhoneApplicationPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Main"/> class.
        /// </summary>
        public Main()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// This method is called when the hardware Back button is pressed.
        /// </summary>
        /// <param name="e">Set e.Cancel to true to indicate that the request was handled by the application.</param>
        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            ICommonUIService commonUIService = new CommonUIService();
            MessageBoxResult result = commonUIService.ShowMessageBox("确认退出?", "退出", true);
            if (result != MessageBoxResult.None && result == MessageBoxResult.OK)
            {
                base.OnBackKeyPress(e);
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}