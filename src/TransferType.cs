// <copyright file = "TransferType.cs " company = "Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

using System;

namespace BudgetExecution
{
    using System.Threading;

    // ******************************************************************************************************************************
    // ******************************************************   MEMBERS   ***********************************************************
    // ******************************************************************************************************************************

    /// <summary>
    /// Defines the TransferType
    /// </summary>
    public enum TransferType
    {
        /// <summary>
        /// Defines the None
        /// </summary>
        None = 0,

        /// <summary>
        /// Defines the Admin
        /// </summary>
        Admin = 1,

        /// <summary>
        /// Defines the BOC
        /// </summary>
        BOC = 2,

        /// <summary>
        /// Defines the FromHQ
        /// </summary>
        FromHq = 3,

        /// <summary>
        /// Defines the ToHQ
        /// </summary>
        ToHq = 4,

        /// <summary>
        /// Defines the FromRpio
        /// </summary>
        FromRpio = 5,

        /// <summary>
        /// Defines the ToRpio
        /// </summary>
        ToRpio = 6,

        /// <summary>
        /// Defines the Recertification
        /// </summary>
        Recertification = 7,

        /// <summary>
        /// Defines the ToDivision
        /// </summary>
        ToDivision = 8,

        /// <summary>
        /// Defines the FromDivsion
        /// </summary>
        FromDivsion = 9,

        /// <summary>
        /// Defines the SubAllowance
        /// </summary>
        SubAllowance = 10
    }
}