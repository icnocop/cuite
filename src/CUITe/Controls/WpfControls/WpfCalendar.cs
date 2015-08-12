using System;
using CUIT = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfCalendar
    /// </summary>
    public class WpfCalendar : WpfControl<CUIT.WpfCalendar>
    {
        public WpfCalendar() : base() { }
        public WpfCalendar(string searchParameters) : base(searchParameters) { }

        public DateTime[] SelectedDates
        {
            get { return this.UnWrap().SelectedDates; }
            set { this.UnWrap().SelectedDates = value; }
        }

        public string SelectedDatesAsString
        {
            get { return this.UnWrap().SelectedDatesAsString; }
            set { this.UnWrap().SelectedDatesAsString = value; }
        }
    }
}