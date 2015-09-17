using System;
using System.Windows.Forms;
using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Represents a control for selecting a date or time in the user interface (UI) of Windows
    /// Forms.
    /// </summary>
    public class WinDateTimePicker : WinControl<CUITControls.WinDateTimePicker>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinDateTimePicker"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinDateTimePicker(By searchConfiguration = null)
            : this(new CUITControls.WinDateTimePicker(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WinDateTimePicker"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinDateTimePicker(CUITControls.WinDateTimePicker sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the calendar part of this date time picker control.
        /// </summary>
        public WinCalendar Calendar
        {
            get { return new WinCalendar((CUITControls.WinCalendar)SourceControl.Calendar); }
        }

        /// <summary>
        /// Gets or sets the selected date and time for this date time picker control.
        /// </summary>
        public DateTime DateTime
        {
            get { return SourceControl.DateTime; }
            set { SourceControl.DateTime = value; }
        }

        /// <summary>
        /// Gets or sets the selected date and time for this date time picker control as a string.
        /// </summary>
        public string DateTimeAsString
        {
            get { return SourceControl.DateTimeAsString; }
            set { SourceControl.DateTimeAsString = value; }
        }

        /// <summary>
        /// Gets the format for this date time picker control.
        /// </summary>
        public DateTimePickerFormat Format
        {
            get { return SourceControl.Format; }
        }

        /// <summary>
        /// Gets a value that indicates whether this date time picker control has a check box
        /// component.
        /// </summary>
        public bool HasCheckBox
        {
            get { return SourceControl.HasCheckBox; }
        }

        /// <summary>
        /// Gets a value that indicates whether this date time picker control has a drop-down
        /// button component.
        /// </summary>
        public bool HasDropDownButton
        {
            get { return SourceControl.HasDropDownButton; }
        }

        /// <summary>
        /// Gets a value that indicates whether this date time picker control has a spinner
        /// component.
        /// </summary>
        public bool HasSpinner
        {
            get { return SourceControl.HasSpinner; }
        }

        /// <summary>
        /// Gets or sets a value that indicates whether the calendar component of this date time
        /// picker control is visible.
        /// </summary>
        public bool ShowCalendar
        {
            get { return SourceControl.ShowCalendar; }
            set { SourceControl.ShowCalendar = value; }
        }
    }
}