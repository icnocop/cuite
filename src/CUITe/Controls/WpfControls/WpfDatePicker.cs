using System;
using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Represents a date picker control to test the user interface (UI) of Windows Presentation
    /// Foundation (WPF) applications.
    /// </summary>
    public class WpfDatePicker : WpfControl<CUITControls.WpfDatePicker>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WpfDatePicker"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfDatePicker(By searchConfiguration = null)
            : this(new CUITControls.WpfDatePicker(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WpfDatePicker"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfDatePicker(CUITControls.WpfDatePicker sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the calendar part of this date picker control.
        /// </summary>
        public WpfCalendar Calendar
        {
            get { return new WpfCalendar((CUITControls.WpfCalendar)SourceControl.Calendar); }
        }

        /// <summary>
        /// Gets or sets the date value of this date picker control.
        /// </summary>
        public DateTime Date
        {
            get { return SourceControl.Date; }
            set { SourceControl.Date = value; }
        }

        /// <summary>
        /// Gets or sets the date value of this date picker control as a string.
        /// </summary>
        public string DateAsString
        {
            get { return SourceControl.DateAsString; }
            set { SourceControl.DateAsString = value; }
        }

        /// <summary>
        /// Gets or sets a value that indicates whether the calendar part of this control is visible.
        /// </summary>
        public bool ShowCalendar
        {
            get { return SourceControl.ShowCalendar; }
            set { SourceControl.ShowCalendar = value; }
        }
    }
}