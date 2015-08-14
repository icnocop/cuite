using System;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfDatePicker
    /// </summary>
    public class WpfDatePicker : WpfControl<CUITControls.WpfDatePicker>
    {
        public WpfDatePicker() { }
        public WpfDatePicker(string searchParameters) : base(searchParameters) { }

        public WpfCalendar Calendar
        {
            get
            {
                WpfCalendar calendar = new WpfCalendar();
                calendar.WrapReady(UnWrap().Calendar);
                return calendar;
            }
        }

        public DateTime Date
        {
            get { return UnWrap().Date; }
            set { UnWrap().Date = value; }
        }

        public string DateAsString
        {
            get { return UnWrap().DateAsString; }
            set { UnWrap().DateAsString = value; }
        }

        public bool ShowCalendar
        {
            get { return UnWrap().ShowCalendar; }
            set { UnWrap().ShowCalendar = value; }
        }
    }
}