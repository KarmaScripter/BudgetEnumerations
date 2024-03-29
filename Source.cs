﻿// ******************************************************************************************
//     Assembly:                Budget Enumerations
//     Author:                  Terry D. Eppler
//     Created:                 06-06-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-06-2023
// ******************************************************************************************
// <copyright file="Source.cs" company="Terry D. Eppler">
//    This is a Federal Budget, Finance, and Accounting application for the
//    US Environmental Protection Agency (US EPA).
//    Copyright ©  2023  Terry Eppler
// 
//    Permission is hereby granted, free of charge, to any person obtaining a copy
//    of this software and associated documentation files (the “Software”),
//    to deal in the Software without restriction,
//    including without limitation the rights to use,
//    copy, modify, merge, publish, distribute, sublicense,
//    and/or sell copies of the Software,
//    and to permit persons to whom the Software is furnished to do so,
//    subject to the following conditions:
// 
//    The above copyright notice and this permission notice shall be included in all
//    copies or substantial portions of the Software.
// 
//    THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//    INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//    FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT.
//    IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
//    DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//    ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//    DEALINGS IN THE SOFTWARE.
// 
//    You can contact me at:   terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   Source.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Threading;

    /// <summary>
    /// 
    /// </summary>
    public enum Source
    {
        /// <summary>
        /// The accounting events
        /// </summary>
        AccountingEvents,

        /// <summary>
        /// The accounts
        /// </summary>
        Accounts,

        /// <summary>
        /// The activity codes
        /// </summary>
        ActivityCodes,

        /// <summary>
        /// The actuals
        /// </summary>
        Actuals,

        /// <summary>
        /// The administrative requests
        /// </summary>
        AdministrativeRequests,

        /// <summary>
        /// The allocations
        /// </summary>
        Allocations,

        /// <summary>
        /// The allowance holders
        /// </summary>
        AllowanceHolders,

        /// <summary>
        /// The american rescue plan carryover estimates
        /// </summary>
        AmericanRescuePlanCarryoverEstimates,

        /// <summary>
        /// The annual carryover estimates
        /// </summary>
        AnnualCarryoverEstimates,

        /// <summary>
        /// The annual carryover survey
        /// </summary>
        AnnualCarryoverSurvey,

        /// <summary>
        /// The annual reimbursable estimates
        /// </summary>
        AnnualReimbursableEstimates,

        /// <summary>
        /// The annual reimbursable survey
        /// </summary>
        AnnualReimbursableSurvey,

        /// <summary>
        /// The application tables
        /// </summary>
        ApplicationTables,

        /// <summary>
        /// The apportionment data
        /// </summary>
        ApportionmentData,

        /// <summary>
        /// The appropriation available balances
        /// </summary>
        AppropriationAvailableBalances,

        /// <summary>
        /// The appropriation documents
        /// </summary>
        AppropriationDocuments,

        /// <summary>
        /// The appropriation level authority
        /// </summary>
        AppropriationLevelAuthority,

        /// <summary>
        /// The appropriations
        /// </summary>
        Appropriations,

        /// <summary>
        /// The budgetary resource execution
        /// </summary>
        BudgetaryResourceExecution,

        /// <summary>
        /// The budget controls
        /// </summary>
        BudgetControls,

        /// <summary>
        /// The budget documents
        /// </summary>
        BudgetDocuments,

        /// <summary>
        /// The budget object classes
        /// </summary>
        BudgetObjectClasses,

        /// <summary>
        /// The budget outlays
        /// </summary>
        BudgetOutlays,

        /// <summary>
        /// The capital planning investment codes
        /// </summary>
        CapitalPlanningInvestmentCodes,

        /// <summary>
        /// The carryover apportionments
        /// </summary>
        CarryoverApportionments,

        /// <summary>
        /// The carryover outlays
        /// </summary>
        CarryoverOutlays,

        /// <summary>
        /// The carryover requests
        /// </summary>
        CarryoverRequests,

        /// <summary>
        /// The changes
        /// </summary>
        Changes,

        /// <summary>
        /// The column schema
        /// </summary>
        ColumnSchema,

        /// <summary>
        /// The compass errors
        /// </summary>
        CompassErrors,

        /// <summary>
        /// The compass levels
        /// </summary>
        CompassLevels,

        /// <summary>
        /// The compass outlays
        /// </summary>
        CompassOutlays,

        /// <summary>
        /// The congressional controls
        /// </summary>
        CongressionalControls,

        /// <summary>
        /// The congressional reprogrammings
        /// </summary>
        CongressionalReprogrammings,

        /// <summary>
        /// The contacts
        /// </summary>
        Contacts,

        /// <summary>
        /// The cost areas
        /// </summary>
        CostAreas,

        /// <summary>
        /// The data rule descriptions
        /// </summary>
        DataRuleDescriptions,

        /// <summary>
        /// The defactos
        /// </summary>
        Defactos,

        /// <summary>
        /// The deobligation activity
        /// </summary>
        DeobligationActivity,

        /// <summary>
        /// The deobligations
        /// </summary>
        Deobligations,

        /// <summary>
        /// The document control numbers
        /// </summary>
        DocumentControlNumbers,

        /// <summary>
        /// The documents
        /// </summary>
        Documents,

        /// <summary>
        /// The earmark codes
        /// </summary>
        EarmarkCodes,

        /// <summary>
        /// The earmarks
        /// </summary>
        Earmarks,

        /// <summary>
        /// The expenditures
        /// </summary>
        Expenditures,

        /// <summary>
        /// The external
        /// </summary>
        External,

        /// <summary>
        /// The federal holidays
        /// </summary>
        FederalHolidays,

        /// <summary>
        /// The finance object classes
        /// </summary>
        FinanceObjectClasses,

        /// <summary>
        /// The fiscal years
        /// </summary>
        FiscalYears,

        /// <summary>
        /// The fiscal years back up
        /// </summary>
        FiscalYearsBackUp,

        /// <summary>
        /// The full time equivalents
        /// </summary>
        FullTimeEquivalents,

        /// <summary>
        /// The fund categories
        /// </summary>
        FundCategories,

        /// <summary>
        /// The funds
        /// </summary>
        Funds,

        /// <summary>
        /// The fund symbols
        /// </summary>
        FundSymbols,

        /// <summary>
        /// The general ledger accounts
        /// </summary>
        GeneralLedgerAccounts,

        /// <summary>
        /// The goals
        /// </summary>
        Goals,

        /// <summary>
        /// The gross authority
        /// </summary>
        GrossAuthority,

        /// <summary>
        /// The gross utilization
        /// </summary>
        GrossUtilization,

        /// <summary>
        /// The growth rates
        /// </summary>
        GrowthRates,

        /// <summary>
        /// The gs pay scales
        /// </summary>
        GsPayScales,

        /// <summary>
        /// The headquarters authority
        /// </summary>
        HeadquartersAuthority,

        /// <summary>
        /// The headquarters offices
        /// </summary>
        HeadquartersOffices,

        /// <summary>
        /// The human resource organizations
        /// </summary>
        HumanResourceOrganizations,

        /// <summary>
        /// The images
        /// </summary>
        Images,

        /// <summary>
        /// The inflation reduction act carryover estimates
        /// </summary>
        InflationReductionActCarryoverEstimates,

        /// <summary>
        /// The jobs act carryover estimates
        /// </summary>
        JobsActCarryoverEstimates,

        /// <summary>
        /// The messages
        /// </summary>
        Messages,

        /// <summary>
        /// The monthly actuals
        /// </summary>
        MonthlyActuals,

        /// <summary>
        /// The monthly ledger account balances
        /// </summary>
        MonthlyLedgerAccountBalances,

        /// <summary>
        /// The monthly outlays
        /// </summary>
        MonthlyOutlays,

        /// <summary>
        /// The national programs
        /// </summary>
        NationalPrograms,

        /// <summary>
        /// The object class outlays
        /// </summary>
        ObjectClassOutlays,

        /// <summary>
        /// The objectives
        /// </summary>
        Objectives,

        /// <summary>
        /// The obligation activity
        /// </summary>
        ObligationActivity,

        /// <summary>
        /// The obligations
        /// </summary>
        Obligations,

        /// <summary>
        /// The open commitments
        /// </summary>
        OpenCommitments,

        /// <summary>
        /// The operating plans
        /// </summary>
        OperatingPlans,

        /// <summary>
        /// The operating plan updates
        /// </summary>
        OperatingPlanUpdates,

        /// <summary>
        /// The organizations
        /// </summary>
        Organizations,

        /// <summary>
        /// The pay periods
        /// </summary>
        PayPeriods,

        /// <summary>
        /// The payroll activity
        /// </summary>
        PayrollActivity,

        /// <summary>
        /// The payroll authority
        /// </summary>
        PayrollAuthority,

        /// <summary>
        /// The payroll cost codes
        /// </summary>
        PayrollCostCodes,

        /// <summary>
        /// The payroll requests
        /// </summary>
        PayrollRequests,

        /// <summary>
        /// The PRC
        /// </summary>
        PRC,

        /// <summary>
        /// The program areas
        /// </summary>
        ProgramAreas,

        /// <summary>
        /// The program financing schedule
        /// </summary>
        ProgramFinancingSchedule,

        /// <summary>
        /// The program project descriptions
        /// </summary>
        ProgramProjectDescriptions,

        /// <summary>
        /// The program projects
        /// </summary>
        ProgramProjects,

        /// <summary>
        /// The project cost codes
        /// </summary>
        ProjectCostCodes,

        /// <summary>
        /// The projects
        /// </summary>
        Projects,

        /// <summary>
        /// The providers
        /// </summary>
        Providers,

        /// <summary>
        /// The public laws
        /// </summary>
        PublicLaws,

        /// <summary>
        /// The query definitions
        /// </summary>
        QueryDefinitions,

        /// <summary>
        /// The recovery act
        /// </summary>
        RecoveryAct,

        /// <summary>
        /// The reference tables
        /// </summary>
        ReferenceTables,

        /// <summary>
        /// The regional authority
        /// </summary>
        RegionalAuthority,

        /// <summary>
        /// The regional offices
        /// </summary>
        RegionalOffices,

        /// <summary>
        /// The reimbursable agreements
        /// </summary>
        ReimbursableAgreements,

        /// <summary>
        /// The reimbursable funds
        /// </summary>
        ReimbursableFunds,

        /// <summary>
        /// The reports
        /// </summary>
        Reports,

        /// <summary>
        /// The reprogrammings
        /// </summary>
        Reprogrammings,

        /// <summary>
        /// The resource planning offices
        /// </summary>
        ResourcePlanningOffices,

        /// <summary>
        /// The resources
        /// </summary>
        Resources,

        /// <summary>
        /// The responsibility centers
        /// </summary>
        ResponsibilityCenters,

        /// <summary>
        /// The schema types
        /// </summary>
        SchemaTypes,

        /// <summary>
        /// The site activity
        /// </summary>
        SiteActivity,

        /// <summary>
        /// The site project codes
        /// </summary>
        SiteProjectCodes,

        /// <summary>
        /// The special accounts
        /// </summary>
        SpecialAccounts,

        /// <summary>
        /// The spending documents
        /// </summary>
        SpendingDocuments,

        /// <summary>
        /// The spending rates
        /// </summary>
        SpendingRates,

        /// <summary>
        /// The state grant obligations
        /// </summary>
        StateGrantObligations,

        /// <summary>
        /// The state organizations
        /// </summary>
        StateOrganizations,

        /// <summary>
        /// The status of american rescue plan funds
        /// </summary>
        StatusOfAmericanRescuePlanFunds,

        /// <summary>
        /// The status of appropriations
        /// </summary>
        StatusOfAppropriations,

        /// <summary>
        /// The status of budgetary resources
        /// </summary>
        StatusOfBudgetaryResources,

        /// <summary>
        /// The status of earmarks
        /// </summary>
        StatusOfEarmarks,

        /// <summary>
        /// The status of funds
        /// </summary>
        StatusOfFunds,

        /// <summary>
        /// The status of inflation reduction act funds
        /// </summary>
        StatusOfInflationReductionActFunds,

        /// <summary>
        /// The status of jobs act funds
        /// </summary>
        StatusOfJobsActFunds,

        /// <summary>
        /// The status of supplemental funds
        /// </summary>
        StatusOfSupplementalFunds,

        /// <summary>
        /// The sub appropriations
        /// </summary>
        SubAppropriations,

        /// <summary>
        /// The superfund sites
        /// </summary>
        SuperfundSites,

        /// <summary>
        /// The supplemental carryover estimates
        /// </summary>
        SupplementalCarryoverEstimates,

        /// <summary>
        /// The supplemental reimburseable estimates
        /// </summary>
        SupplementalReimburseableEstimates,

        /// <summary>
        /// The transfer activity
        /// </summary>
        TransferActivity,

        /// <summary>
        /// The transfers
        /// </summary>
        Transfers,

        /// <summary>
        /// The trans types
        /// </summary>
        TransTypes,

        /// <summary>
        /// The treasury symbols
        /// </summary>
        TreasurySymbols,

        /// <summary>
        /// The unliquidated obligations
        /// </summary>
        UnliquidatedObligations,

        /// <summary>
        /// The unobligated authority
        /// </summary>
        UnobligatedAuthority,

        /// <summary>
        /// The unobligated balances
        /// </summary>
        UnobligatedBalances,

        /// <summary>
        /// The URL
        /// </summary>
        URL,

        /// <summary>
        /// The work codes
        /// </summary>
        WorkCodes
    }
}