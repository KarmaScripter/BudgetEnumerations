// <copyright file = "STAT.cs " company = "Terry D. Eppler">
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
    /// Defines the STAT
    /// </summary>
    public enum STAT
    {
        /// <summary>
        /// Defines the None
        /// </summary>
        None = 0,

        /// <summary>
        /// Defines the Total
        /// </summary>
        Total = 1,

        /// <summary>
        /// Defines the Count
        /// </summary>
        Count = 2,

        /// <summary>
        /// Defines the Average
        /// </summary>
        Average = 3,

        /// <summary>
        /// Defines the Percentage
        /// </summary>
        Percentage = 4,

        /// <summary>
        /// The standard deviation
        /// </summary>
        StandardDeviation = 5,

        /// <summary>
        /// The variance
        /// </summary>
        Variance = 6
    }
}