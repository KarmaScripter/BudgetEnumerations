// <copyright file = "Provider.cs " company = "Terry D. Eppler">
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
    /// Defines the Provider
    /// </summary>
    public enum Provider
    {
        /// <summary>
        /// Defines the None
        /// </summary>
        None = 0,

        /// <summary>
        /// Defines the SQLite
        /// </summary>
        SQLite = 1,

        /// <summary>
        /// Defines the Excel
        /// </summary>
        Excel = 2,

        /// <summary>
        /// Defines the SqlServer
        /// </summary>
        SqlServer = 3,

        /// <summary>
        /// Defines the SqlCe
        /// </summary>
        SqlCe = 4,

        /// <summary>
        /// Defines the Access
        /// </summary>
        Access = 5,

        /// <summary>
        /// Defines the OleDb
        /// </summary>
        OleDb = 6,

        /// <summary>
        /// Defines the CSV
        /// </summary>
        CSV
    }
}