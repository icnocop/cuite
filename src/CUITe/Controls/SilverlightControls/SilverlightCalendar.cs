#if SILVERLIGHT_SUPPORT
using System;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightCalendar.
    /// </summary>
    public class SilverlightCalendar : SilverlightControl<CUITControls.SilverlightCalendar>
    {
        public SilverlightCalendar() : base() { }
        public SilverlightCalendar(string searchParameters) : base(searchParameters) { }

        public System.Windows.Forms.SelectionRange SelectedDateRange
        {
            set
            {
                _control.WaitForControlReady();
                _control.SelectedDateRange = value;
            }
        }

        public string SelectedDateRangeAsString
        {
            set
            {
                _control.WaitForControlReady();
                _control.SelectedDateRangeAsString = value;
            }
        }

        public int SelectionMode
        {
            get
            {
                _control.WaitForControlReady();
                return _control.SelectionMode;
            }
        }

        public DateTime[] SelectedDates
        {
            get 
            {
                _control.WaitForControlReady();
                return _control.SelectedDates;
            }
            set
            {
                _control.WaitForControlReady();
                _control.SelectedDates = value;
            }
        }

        public string SelectedDatesAsString
        {
            get
            {
                _control.WaitForControlReady();
                return _control.SelectedDatesAsString;
            }
            set
            {
                _control.WaitForControlReady();
                _control.SelectedDatesAsString = value;
            }
        }
    }
}
#endif