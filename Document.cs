// <copyright file = "Document.cs " company = "Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    using System;
    using System.Threading;

    // ******************************************************************************************************************************
    // ******************************************************   MEMBERS   ***********************************************************
    // ******************************************************************************************************************************

    /// <summary>
    /// Defines the Report
    /// </summary>
    public enum Document
    {
        /// <summary>
        /// Defines the None
        /// </summary>
        NS = 0,

        /// <summary>
        /// Defines the Internal
        /// </summary>
        Budget = 1,

        /// <summary>
        /// Defines the External
        /// </summary>
        External = 2,

        /// <summary>
        /// Defines the Budget
        /// </summary>
        Report = 3,

        /// <summary>
        /// Defines the Analysis
        /// </summary>
        Analysis = 4
    }
}