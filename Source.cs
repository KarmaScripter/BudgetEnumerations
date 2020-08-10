// // <copyright file = "Source.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

using System;

namespace BudgetExecution
{
    using System.Threading;

    // ******************************************************************************************************************************
    // ******************************************************   MEMBERS   ***********************************************************
    // ******************************************************************************************************************************

    /// <summary>
    /// Defines the Source
    /// </summary>
    public enum Source
    {
        NS = 0,

        /// <summary>
        /// Defines the Allocations
        /// </summary>
        Allocations,

        /// <summary>
        /// Defines the Accounts
        /// </summary>
        Accounts,

        /// <summary>
        /// Defines the Supplemental
        /// </summary>
        Supplemental,

        /// <summary>
        /// Defines the ControlNumbers
        /// </summary>
        ControlNumbers,

        /// <summary>
        /// Defines the DivisionAuthority
        /// </summary>
        DivisionAuthority,

        /// <summary>
        /// The division execution
        /// </summary>
        DivisionExecution,

        /// <summary>
        /// Defines the RegionAuthority
        /// </summary>
        RegionAuthority,

        /// <summary>
        /// The region execution
        /// </summary>
        RegionExecution,

        /// <summary>
        /// Defines the TravelObligations
        /// </summary>
        TravelObligations,

        /// <summary>
        /// Defines the Divisions
        /// </summary>
        Divisions,

        /// <summary>
        /// Defines the EJ
        /// </summary>
        EJ,

        /// <summary>
        /// Defines the Employees
        /// </summary>
        Employees,

        /// <summary>
        /// Defines the ECAD
        /// </summary>
        ECAD,

        /// <summary>
        /// Defines the ContactData
        /// </summary>
        ContactData,

        /// <summary>
        /// Defines the EPM
        /// </summary>
        EPM,

        /// <summary>
        /// Defines the ExternalTransfers
        /// </summary>
        ExternalTransfers,

        /// <summary>
        /// Defines the Funds
        /// </summary>
        Funds,

        /// <summary>
        /// Defines the FiscalYears
        /// </summary>
        FiscalYears,

        /// <summary>
        /// Defines the Appropriations
        /// </summary>
        Appropriations,

        /// <summary>
        /// Defines the CategoricalGrants
        /// </summary>
        CategoricalGrants,

        /// <summary>
        /// Defines the CleanWaterStateRevolvingFund
        /// </summary>
        CleanWaterStateRevolvingFund,

        /// <summary>
        /// Defines the DrinkingWaterStateRevolvingFund
        /// </summary>
        DrinkingWaterStateRevolvingFund,

        /// <summary>
        /// Defines the SpecialProjectsAndEarmarks
        /// </summary>
        SpecialProjectsAndEarmarks,

        /// <summary>
        /// Defines the NonSiteTravel
        /// </summary>
        NonSiteTravel,

        /// <summary>
        /// Defines the InternalTransfers
        /// </summary>
        InternalTransfers,

        /// <summary>
        /// Defines the ProgramResultsCode
        /// </summary>
        PRC,

        /// <summary>
        /// Defines the Programs
        /// </summary>
        Programs,

        /// <summary>
        /// Defines the WorkforceData
        /// </summary>
        WorkforceData,

        /// <summary>
        /// Defines the LeaveData
        /// </summary>
        LeaveData,

        /// <summary>
        /// Defines the BudgetObjectClass
        /// </summary>
        BudgetObjectClass,

        /// <summary>
        /// Defines the WorkCodes
        /// </summary>
        WorkCodes,

        /// <summary>
        /// Defines the HumanResourceOrganizations
        /// </summary>
        HumanResourceOrganizations,

        /// <summary>
        /// Defines the Activity
        /// </summary>
        Activity,

        /// <summary>
        /// Defines the PayrollObligations
        /// </summary>
        PayrollObligations,

        /// <summary>
        /// Defines the Sites
        /// </summary>
        Sites,

        /// <summary>
        /// Defines the WSA
        /// </summary>
        WSA,

        /// <summary>
        /// Defines the WCF
        /// </summary>
        WCF,

        /// <summary>
        /// Defines the MDR
        /// </summary>
        MDR,

        /// <summary>
        /// Defines the XA
        /// </summary>
        XA,

        /// <summary>
        /// Defines the Payroll
        /// </summary>
        Payroll,

        /// <summary>
        /// The payroll hours
        /// </summary>
        PayrollHours,

        /// <summary>
        /// Defines the Reimbursables
        /// </summary>
        Reimbursables,

        /// <summary>
        /// Defines the LUST
        /// </summary>
        LUST,

        /// <summary>
        /// Defines the OilSpill
        /// </summary>
        OilSpill,

        /// <summary>
        /// Defines the STAG
        /// </summary>
        STAG,

        /// <summary>
        /// Defines the SF6A
        /// </summary>
        SF6A,

        /// <summary>
        /// Defines the Superfund
        /// </summary>
        Superfund,

        /// <summary>
        /// Defines the MSD
        /// </summary>
        MSD,

        /// <summary>
        /// Defines the ORC
        /// </summary>
        ORC,

        /// <summary>
        /// Defines the ORA
        /// </summary>
        ORA,

        /// <summary>
        /// Defines the SEMD
        /// </summary>
        SEMD,

        /// <summary>
        /// Defines the LCARD
        /// </summary>
        LCARD,

        /// <summary>
        /// Defines the LSASD
        /// </summary>
        LSASD,

        /// <summary>
        /// Defines the Transfers
        /// </summary>
        Transfers,

        /// <summary>
        /// Defines the WD
        /// </summary>
        WD,

        /// <summary>
        /// Defines the AppropriationBills
        /// </summary>
        AppropriationBills,

        /// <summary>
        /// Defines the ARD
        /// </summary>
        ARD,

        /// <summary>
        /// Defines the FullTimeEquivalent
        /// </summary>
        FTE,

        /// <summary>
        /// Defines the Travel
        /// </summary>
        Travel,

        /// <summary>
        /// Defines the SiteTravel
        /// </summary>
        SiteTravel,

        /// <summary>
        /// Defines the Expenses
        /// </summary>
        Expenses,

        /// <summary>
        /// Defines the Contracts
        /// </summary>
        Contracts,

        /// <summary>
        /// Defines the Grants
        /// </summary>
        Grants,

        /// <summary>
        /// Defines the AllowanceHolders
        /// </summary>
        AllowanceHolders,

        /// <summary>
        /// Defines the ResourcePlanningOffices
        /// </summary>
        ResourcePlanningOffices,

        /// <summary>
        /// Defines the TIM
        /// </summary>
        InformationTechnology,

        /// <summary>
        /// Defines the Organizations
        /// </summary>
        Organizations,

        /// <summary>
        /// Defines the ResponsibilityCenters
        /// </summary>
        ResponsibilityCenters,

        /// <summary>
        /// Defines the NationalPrograms
        /// </summary>
        NationalPrograms,

        /// <summary>
        /// Defines the ProgramProjects
        /// </summary>
        ProgramProjects,

        /// <summary>
        /// Defines the FinanceObjectClass
        /// </summary>
        FinanceObjectClass,

        /// <summary>
        /// Defines the Goals
        /// </summary>
        Goals,

        /// <summary>
        /// Defines the Objectives
        /// </summary>
        Objectives,

        /// <summary>
        /// Defines the ProgramAreas
        /// </summary>
        ProgramAreas,

        /// <summary>
        /// Defines the Utilization
        /// </summary>
        Utilization,

        /// <summary>
        /// Defines the Outlays
        /// </summary>
        Outlays,

        /// <summary>
        /// Defines the External
        /// </summary>
        External,

        /// <summary>
        /// Defines the SpecialAccounts
        /// </summary>
        SpecialAccounts,

        /// <summary>
        /// Defines the SuperfundSupplemental
        /// </summary>
        SuperfundSupplemental,

        /// <summary>
        /// Defines the LustSupplemental
        /// </summary>
        LustSupplemental,

        /// <summary>
        /// Defines the DeepWaterHorizon
        /// </summary>
        DeepWaterHorizon,

        /// <summary>
        /// Defines the FullTimeEquivalents
        /// </summary>
        FullTimeEquivalents,

        /// <summary>
        /// Defines the Purchases
        /// </summary>
        Purchases,

        /// <summary>
        /// The obligations
        /// </summary>
        Obligations,

        /// <summary>
        /// The commitments
        /// </summary>
        Commitments,

        /// <summary>
        /// The open commitments
        /// </summary>
        OpenCommitments,

        /// <summary>
        /// The deobligations
        /// </summary>
        Deobligations,

        /// <summary>
        /// The unliquidated obligations
        /// </summary>
        UnliquidatedObligations,

        /// <summary>
        /// The expenditures
        /// </summary>
        Expenditures,

        /// <summary>
        /// Defines the Awards
        /// </summary>
        Awards,

        /// <summary>
        /// Defines the TimeOff
        /// </summary>
        TimeOff,

        /// <summary>
        /// Defines the Overtime
        /// </summary>
        Overtime,

        /// <summary>
        /// Defines the LeaveProjections
        /// </summary>
        LeaveProjections,

        /// <summary>
        /// Defines the Reprogrammings
        /// </summary>
        Reprogrammings,

        /// <summary>
        /// Defines the StatusOfFunds
        /// </summary>
        StatusOfFunds,

        /// <summary>
        /// Defines the BudgetLevels
        /// </summary>
        BudgetLevels,

        /// <summary>
        /// The vendors
        /// </summary>
        Vendors,

        /// <summary>
        /// Creates new obligationalauthority.
        /// </summary>
        NewObligationalAuthority,

        /// <summary>
        /// The carry over
        /// </summary>
        CarryOver,

        /// <summary>
        /// The procurements
        /// </summary>
        Procurements,

        /// <summary>
        /// The payments
        /// </summary>
        Payments,

        /// <summary>
        /// The requisitions
        /// </summary>
        Requisitions,

        /// <summary>
        /// The purchase activity
        /// </summary>
        PurchaseActivity
    }
}
