// <copyright file="{ClassName}.cs" company="Terry D. Eppler">
// Copyright (c) Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm" />
    public partial class EnumerationError
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnumerationError"/> class.
        /// </summary>
        public EnumerationError()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumerationError"/> class.
        /// </summary>
        /// <param name="ext">The ext.</param>
        public EnumerationError( Exception ext )
        {
            InitializeComponent();
            Exception = ext;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumerationError"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public EnumerationError( string message )
        {
            InitializeComponent();
            Text = message;
        }

        /// <summary>
        /// Gets the exception.
        /// </summary>
        /// <value>
        /// The exception.
        /// </value>
        public Exception Exception { get; }

        /// <summary>
        /// Gets or sets the text associated with this control.
        /// </summary>
        public new string Text { get; set; }

        /// <summary>
        /// Sets the text.
        /// </summary>
        public void SetText()
        {
        }
    }
}
