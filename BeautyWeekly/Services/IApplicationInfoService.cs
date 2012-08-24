using BeautyWeekly.Services;
//-----------------------------------------------------------------------
// <copyright file="IApplicationInfoService.cs" company="eggfly">
//     Copyright (c) eggfly. All rights reserved.
// </copyright>
// <author>eggfly</author>
//-----------------------------------------------------------------------

namespace BeautyWeekly.Services
{
    using System;
    using System.Linq;
    using System.Windows;

    /// <summary>
    /// Network Status Enum
    /// </summary>
    public enum NetworkStatusEnum
    {
        /// <summary>
        /// no network
        /// </summary>
        Disconnected = 0,

        /// <summary>
        /// Wifi
        /// </summary>
        Wifi,

        /// <summary>
        /// Cellular network
        /// </summary>
        Mobile,
    }

    /// <summary>
    /// IApplicationInfoService Interface
    /// </summary>
    public interface IApplicationInfoService
    {
        /// <summary>
        /// Gets the device unique id.
        /// </summary>
        string DeviceUniqueId
        {
            get;
        }

        /// <summary>
        /// Gets the OS version.
        /// </summary>
        string OSVersion
        {
            get;
        }

        /// <summary>
        /// Gets the OS version.
        /// </summary>
        string VersionNumber
        {
            get;
        }

        /// <summary>
        /// Gets the name of the device.
        /// </summary>
        /// <value>
        /// The name of the device.
        /// </value>
        string DeviceName
        {
            get;
        }

        /// <summary>
        /// Gets the device status.
        /// </summary>
        string DeviceStatus
        {
            get;
        }

        /// <summary>
        /// Gets a value indicating whether this instance is using wifi.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is using wifi; otherwise, <c>false</c>.
        /// </value>
        NetworkStatusEnum NetworkStatus
        {
            get;
        }

        /// <summary>
        /// Gets the app ID.
        /// </summary>
        string AppID
        {
            get;
        }

    }
}
