﻿// <copyright file = "ExpenseType.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Threading;

    /// <summary>
    /// Defines the ExpenseType
    /// </summary>
    public enum ExpenseType
    {
        // ******************************************************************************************************************************
        // ******************************************************   MEMBERS   ***********************************************************
        // ******************************************************************************************************************************

        /// <summary>
        /// Defines the None
        /// </summary>
        NS = 0,

        /// <summary>
        /// Defines the Commitment
        /// </summary>
        Commitment,

        /// <summary>
        /// Defines the OpenCommitment
        /// </summary>
        OpenCommitment,

        /// <summary>
        /// Defines the Obligation
        /// </summary>
        Obligation,

        /// <summary>
        /// Defines the ULO
        /// </summary>
        ULO,

        /// <summary>
        /// The deobligation
        /// </summary>
        Deobligation,

        /// <summary>
        /// Defines the Expenditure
        /// </summary>
        Expenditure,

        /// <summary>
        /// Defines the All
        /// </summary>
        All
    }
}