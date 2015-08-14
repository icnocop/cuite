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
        public SilverlightCalendar()
        {
        }

        public SilverlightCalendar(string searchParameters)
            : base(searchParameters)
        {
        }

        public SelectionRange SelectedDateRange
        {
            set
            {
                SourceControl.WaitForControlReady();
                SourceControl.SelectedDateRange = value;
            }
        }

        public string SelectedDateRangeAsString
        {
            set
            {
                SourceControl.WaitForControlReady();
                SourceControl.SelectedDateRangeAsString = value;
            }
        }

        public int SelectionMode
        {
            get
            {
                SourceControl.WaitForControlReady();
                return SourceControl.SelectionMode;
            }
        }

        public DateTime[] SelectedDates
        {
            get
            {
                SourceControl.WaitForControlReady();
                return SourceControl.SelectedDates;
            }
            set
            {
                SourceControl.WaitForControlReady();
                SourceControl.SelectedDates = value;
            }
        }

        public string SelectedDatesAsString
        {
            get
            {
                SourceControl.WaitForControlReady();
                return SourceControl.SelectedDatesAsString;
            }
            set
            {
                SourceControl.WaitForControlReady();
                SourceControl.SelectedDatesAsString = value;
            }
        }
    }
}
#endif