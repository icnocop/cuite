﻿#if SILVERLIGHT_SUPPORT
using CUITe.SearchConfigurations;
using System;
using System.Windows.Forms;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// Represents a calendar control to test the user interface (UI) of a Silverlight application.
    /// </summary>
    public class SilverlightCalendar : SilverlightControl<CUITControls.SilverlightCalendar>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightCalendar"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightCalendar(By searchConfiguration = null)
            : this(new CUITControls.SilverlightCalendar(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightCalendar"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightCalendar(CUITControls.SilverlightCalendar sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Sets the currently selected date range on the calendar.
        /// </summary>
        public SelectionRange SelectedDateRange
        {
            set
            {
                WaitForControlReady();
                SourceControl.SelectedDateRange = value;
            }
        }

        /// <summary>
        /// Sets the currently selected date range on the calendar by using a string.
        /// </summary>
        public string SelectedDateRangeAsString
        {
            set
            {
                WaitForControlReady();
                SourceControl.SelectedDateRangeAsString = value;
            }
        }

        /// <summary>
        /// Gets a value that indicates the selection mode of the calendar.
        /// </summary>
        public int SelectionMode
        {
            get
            {
                WaitForControlReady();
                return SourceControl.SelectionMode;
            }
        }

        /// <summary>
        /// Gets or sets the selected dates on the calendar.
        /// </summary>
        public DateTime[] SelectedDates
        {
            get
            {
                WaitForControlReady();
                return SourceControl.SelectedDates;
            }
            set
            {
                WaitForControlReady();
                SourceControl.SelectedDates = value;
            }
        }

        /// <summary>
        /// Gets or sets the selected dates on the calendar as a string.
        /// </summary>
        public string SelectedDatesAsString
        {
            get
            {
                WaitForControlReady();
                return SourceControl.SelectedDatesAsString;
            }
            set
            {
                WaitForControlReady();
                SourceControl.SelectedDatesAsString = value;
            }
        }
    }
}
#endif