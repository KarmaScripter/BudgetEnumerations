// <copyright file = "EXT.cs " company = "Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

using System;

namespace BudgetExecution
{
    using System.Threading;

    /// <summary>
    /// Defines the EXT
    /// </summary>
    public enum EXT
    {
        // ******************************************************************************************************************************
        // ******************************************************   MEMBERS   ***********************************************************
        // ******************************************************************************************************************************

        /// <summary>
        /// Defines the None
        /// </summary>
        NS = 0,

        /// <summary>
        /// Defines the DB on SQLite database files.
        /// </summary>
        DB,

        /// <summary>
        /// Defines the ACCDB on newer MS Access database files.
        /// </summary>
        ACCDB,

        /// <summary>
        /// Defines the MDB on older MS Access database files.
        /// </summary>
        MDB,

        /// <summary>
        /// Defines the SDF on MS SQL Server Compact Edition database files.
        /// </summary>
        SDF,

        /// <summary>
        /// Defines the MDF on MS SQL Server database files.
        /// </summary>
        MDF,

        /// <summary>
        /// Defines the XLS on older MS Excel files.
        /// </summary>
        XLS,

        /// <summary>
        /// Defines the XLSX on newer MS Excel files.
        /// </summary>
        XLSX,

        /// <summary>
        /// Defines the CSV on Comma Seperated Value files.
        /// </summary>
        CSV,

        /// <summary>
        /// Defines the TXT on Text files.
        /// </summary>
        TXT,

        /// <summary>
        /// Defines the PDF on Portable Document Codec files.
        /// </summary>
        PDF,

        /// <summary>
        /// Defines the DOCX on newer MS Word files.
        /// </summary>
        DOCX,

        /// <summary>
        /// Defines the DOC on older MS Word files.
        /// </summary>
        DOC,

        /// <summary>
        /// The SQL
        /// </summary>
        SQL,

        /// <summary>
        /// The RESX
        /// </summary>
        RESX,

        /// <summary>
        /// The DLL
        /// </summary>
        DLL,

        /// <summary>
        /// The executable
        /// </summary>
        EXE
    }
}