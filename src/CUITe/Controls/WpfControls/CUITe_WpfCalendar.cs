using System;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfCalendar
    /// </summary>
    public class CUITe_WpfCalendar : CUITe_WpfControl<WpfCalendar>
    {
        public CUITe_WpfCalendar() : base() { }
        public CUITe_WpfCalendar(string searchParameters) : base(searchParameters) { }

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