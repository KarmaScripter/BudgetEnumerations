﻿// <copyright file = "ImageFormat.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    using System.Threading;
    using System;

    /// <summary> Defines the Enum </summary>
    public enum ImageFormat
    {
        // ******************************************************************************************************************************
        // ******************************************************   MEMBERS   ***********************************************************
        // ******************************************************************************************************************************

        /// <summary>
        /// Defines the None
        /// </summary>
        NS = 0,

        /// <summary>
        /// The PNG
        /// </summary>
        PNG,

        /// <summary>
        /// The JPEG
        /// </summary>
        JPEG,

        /// <summary>
        /// The BMP
        /// </summary>
        BMP,

        /// <summary>
        /// The icon
        /// </summary>
        ICO,

        /// <summary>
        /// The GIF
        /// </summary>
        GIF,

        /// <summary>
        /// The RESX
        /// </summary>
        RESX
    }
}
