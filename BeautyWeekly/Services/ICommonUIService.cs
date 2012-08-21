//-----------------------------------------------------------------------
// <copyright file="ICommonUIService.cs" company="Eggfly Corporation">
//     Copyright (c) Eggfly Corporation. All rights reserved.
// </copyright>
// <author>lihaohua90@gmail.com</author>
//-----------------------------------------------------------------------

namespace BeautyWeekly
{
    using System;
    using System.Linq;
    using System.Windows;

    /// <summary>
    /// ICommonUIService Interface
    /// </summary>
    public interface ICommonUIService
    {
        /// <summary>
        /// Shows the message box.
        /// </summary>
        /// <param name="messageBoxText">The message box text.</param>
        /// <param name="caption">The caption.</param>
        /// <param name="isShowOKCancel">if set to <c>true</c> [is show OK cancel].</param>
        /// <returns>the result</returns>
        MessageBoxResult ShowMessageBox(string messageBoxText, string caption = "", bool isShowOKCancel = false);
    }
}
