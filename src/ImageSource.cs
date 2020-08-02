// <copyright file = "ImageSource.cs " company = "Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

using System;

namespace BudgetExecution
{
    using System.Threading;

    /// <summary>
    /// Respresent key values in the Images section
    /// of the App.Config file; The values for each
    /// key comprise the paths to the image files;
    /// </summary>
    public enum ImageSource
    {
        // ******************************************************************************************************************************
        // ******************************************************    MEMBERS     ********************************************************
        // ******************************************************************************************************************************

        /// <summary>
        /// The ns
        /// </summary>
        NS,

        /// <summary>
        /// The object class icons
        /// </summary>
        ObjectClassIcons,

        /// <summary>
        /// The object class images
        /// </summary>
        ObjectClassImages,

        /// <summary>
        /// The summary images
        /// </summary>
        SummaryImages,

        /// <summary>
        /// The database images
        /// </summary>
        Databases,

        /// <summary>
        /// The data icons
        /// </summary>
        DataIcons,

        /// <summary>
        /// The office icons
        /// </summary>
        OfficeIcons,

        /// <summary>
        /// The navigation icons
        /// </summary>
        NavigationIcons,

        /// <summary>
        /// The format icons
        /// </summary>
        FormatIcons,

        /// <summary>
        /// The outlay icons
        /// </summary>
        OutlayIcons,

        /// <summary>
        /// The outlay images
        /// </summary>
        OutlayImages,

        /// <summary>
        /// The file icons
        /// </summary>
        FileIcons,

        /// <summary>
        /// The provider icons
        /// </summary>
        ProviderIcons,

        /// <summary>
        /// The math icons
        /// </summary>
        MathIcons,

        /// <summary>
        /// The mail icons
        /// </summary>
        MailIcons,

        /// <summary>
        /// The interface icons
        /// </summary>
        InterfaceIcons,

        /// <summary>
        /// The division images
        /// </summary>
        DivisionImages,

        /// <summary>
        /// The division icons
        /// </summary>
        DivisionIcons,

        /// <summary>
        /// The folder icons
        /// </summary>
        FolderIcons,

        /// <summary>
        /// The division caption
        /// </summary>
        DivisionCaption,

        /// <summary>
        /// The fund images
        /// </summary>
        FundImages,

        /// <summary>
        /// The employee icons
        /// </summary>
        EmployeeIcons,

        /// <summary>
        /// The main form images
        /// </summary>
        MainFormImages,

        /// <summary>
        /// The execution images
        /// </summary>
        ExecutionImages,

        /// <summary>
        /// The execution icons
        /// </summary>
        ExecutionIcons,

        /// <summary>
        /// The loader images
        /// </summary>
        LoaderImages,

        /// <summary>
        /// The identification icons
        /// </summary>
        IdentificationIcons,

        /// <summary>
        /// The reference images
        /// </summary>
        ReferenceImages,

        /// <summary>
        /// The toolbar
        /// </summary>
        ToolBar
    }
}