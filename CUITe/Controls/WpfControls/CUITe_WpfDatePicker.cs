using System;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfDatePicker
    /// </summary>
    public class CUITe_WpfDatePicker : CUITe_WpfControl<WpfDatePicker>
    {
        public CUITe_WpfDatePicker() : base() { }
        public CUITe_WpfDatePicker(string searchParameters) : base(searchParameters) { }

        public CUITe_WpfCalendar Calendar
        {
            get
            {
                CUITe_WpfCalendar calendar = new CUITe_WpfCalendar();
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