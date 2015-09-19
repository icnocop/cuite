using System;
using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Represents a calendar control to test the user interface (UI) of Windows Presentation
    /// Foundation (WPF) applications.
    /// </summary>
    public class WpfCalendar : WpfControl<CUITControls.WpfCalendar>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WpfCalendar"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfCalendar(By searchConfiguration = null)
            : this(new CUITControls.WpfCalendar(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WpfCalendar"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfCalendar(CUITControls.WpfCalendar sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets or sets an array of the selected dates in this calendar control.
        /// </summary>
        public DateTime[] SelectedDates
        {
            get { return SourceControl.SelectedDates; }
            set { SourceControl.SelectedDates = value; }
        }

        /// <summary>
        /// Gets or sets the selected dates in this calendar control as a string.
        /// </summary>
        public string SelectedDatesAsString
        {
            get { return SourceControl.SelectedDatesAsString; }
            set { SourceControl.SelectedDatesAsString = value; }
        }
    }
}