﻿// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    /// <summary>
    /// 
    /// </summary>
    public enum Level
    {
        /// <summary>
        /// The ns
        /// </summary>
        Treasury = 0,

        /// <summary>
        /// The appropriation
        /// </summary>
        Appropriation = 1,

        /// <summary>
        /// The allowance holder
        /// </summary>
        AllowanceHolder = 3,
        
        /// <summary>
        /// The rpio
        /// </summary>
        RPIO = 2,

        /// <summary>
        /// The program area
        /// </summary>
        ProgramArea = 4,

        /// <summary>
        /// The program project
        /// </summary>
        ProgramProject = 5,

        /// <summary>
        /// The program results code
        /// </summary>
        ProgramResultsCode = 6,

        /// <summary>
        /// The budget object class
        /// </summary>
        BudgetObjectClass = 7,

        /// <summary>
        /// The sub allocation
        /// </summary>
        SubAllocation = 8
    }
}