#if SILVERLIGHT_SUPPORT
using System;
using System.Windows.Forms;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightCalendar.
    /// </summary>
    public class SilverlightCalendar : SilverlightControl<CUITControls.SilverlightCalendar>
    {
        public SilverlightCalendar(CUITControls.SilverlightCalendar sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.SilverlightCalendar(), searchProperties)
        {
        }

        public SelectionRange SelectedDateRange
        {
            set
            {
                WaitForControlReady();
                SourceControl.SelectedDateRange = value;
            }
        }

        public string SelectedDateRangeAsString
        {
            set
            {
                WaitForControlReady();
                SourceControl.SelectedDateRangeAsString = value;
            }
        }

        public int SelectionMode
        {
            get
            {
                WaitForControlReady();
                return SourceControl.SelectionMode;
            }
        }

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