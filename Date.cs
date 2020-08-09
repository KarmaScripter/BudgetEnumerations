// <copyright file="Date.cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public enum Date
    {
        // ******************************************************************************************************************************
        // ******************************************************   MEMBERS   ***********************************************************
        // ******************************************************************************************************************************

        /// <summary>
        /// The ns
        /// </summary>
        NS = 0,

        /// <summary>
        /// The closed date
        /// </summary>
        ClosedDate,

        /// <summary>
        /// The request date
        /// </summary>
        RequestDate,

        /// <summary>
        /// The document date
        /// </summary>
        DocumentDate,

        /// <summary>
        /// The check date
        /// </summary>
        CheckDate,

        /// <summary>
        /// The invoice date
        /// </summary>
        InvoiceDate,

        /// <summary>
        /// The approved date
        /// </summary>
        ApprovedDate,

        /// <summary>
        /// The modified date
        /// </summary>
        ModifiedDate,

        /// <summary>
        /// The start date
        /// </summary>
        StartDate,

        /// <summary>
        /// The end date
        /// </summary>
        EndDate,

        /// <summary>
        /// The approval date
        /// </summary>
        ApprovalDate,

        /// <summary>
        /// The date
        /// </summary>
        Date,

        /// <summary>
        /// The departure date
        /// </summary>
        DepartureDate,

        /// <summary>
        /// The return date
        /// </summary>
        ReturnDate,

        /// <summary>
        /// The original action date
        /// </summary>
        OriginalActionDate,

        /// <summary>
        /// The service date
        /// </summary>
        ServiceDate,

        /// <summary>
        /// The hire date
        /// </summary>
        HireDate,

        /// <summary>
        /// The grade entry date
        /// </summary>
        GradeEntryDate,

        /// <summary>
        /// The step entry date
        /// </summary>
        StepEntryDate,

        /// <summary>
        /// The wigi due date
        /// </summary>
        WigiDueDate,

        /// <summary>
        /// The processed date
        /// </summary>
        ProcessedDate,

        /// <summary>
        /// The calendar date
        /// </summary>
        CalendarDate,

        /// <summary>
        /// The date issued
        /// </summary>
        DateIssued,

        /// <summary>
        /// The enacted date
        /// </summary>
        EnactedDate,

        /// <summary>
        /// The bfy
        /// </summary>
        BFY,

        /// <summary>
        /// The bbfy
        /// </summary>
        BBFY,

        /// <summary>
        /// The ebfy
        /// </summary>
        EBFY,

        /// <summary>
        /// The first year
        /// </summary>
        FirstYear,

        /// <summary>
        /// The last year
        /// </summary>
        LastYear,

        /// <summary>
        /// The last action date
        /// </summary>
        LastActionDate,

        /// <summary>
        /// The cancellation date
        /// </summary>
        CancellationDate,

        /// <summary>
        /// Creates new years.
        /// </summary>
        NewYears,

        /// <summary>
        /// The martin luther king
        /// </summary>
        MartinLutherKing,

        /// <summary>
        /// The presidents
        /// </summary>
        Presidents,

        /// <summary>
        /// The memorial
        /// </summary>
        Memorial,

        /// <summary>
        /// The independence
        /// </summary>
        Independence,

        /// <summary>
        /// The veterans
        /// </summary>
        Veterans,

        /// <summary>
        /// The labor
        /// </summary>
        Labor,

        /// <summary>
        /// The columbus
        /// </summary>
        Columbus,

        /// <summary>
        /// The thanksgiving
        /// </summary>
        Thanksgiving,

        /// <summary>
        /// The christmas
        /// </summary>
        Christmas,

        /// <summary>
        /// The time
        /// </summary>
        Time
    }
}