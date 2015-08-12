using System;
using CUIT = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfDatePicker
    /// </summary>
    public class WpfDatePicker : WpfControl<CUIT.WpfDatePicker>
    {
        public WpfDatePicker() : base() { }
        public WpfDatePicker(string searchParameters) : base(searchParameters) { }

        public WpfCalendar Calendar
        {
            get
            {
                WpfCalendar calendar = new WpfCalendar();
                calendar.WrapReady(this.UnWrap().Calendar);
                return calendar;
            }
        }

        public DateTime Date
        {
            get { return this.UnWrap().Date; }
            set { this.UnWrap().Date = value; }
        }

        public string DateAsString
        {
            get { return this.UnWrap().DateAsString; }
            set { this.UnWrap().DateAsString = value; }
        }

        public bool ShowCalendar
        {
            get { return this.UnWrap().ShowCalendar; }
            set { this.UnWrap().ShowCalendar = value; }
        }
    }
}