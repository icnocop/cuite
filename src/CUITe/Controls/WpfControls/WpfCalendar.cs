using System;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfCalendar
    /// </summary>
    public class WpfCalendar : WpfControl<CUITControls.WpfCalendar>
    {
        public WpfCalendar()
        {
        }

        public WpfCalendar(string searchParameters)
            : base(searchParameters)
        {
        }

        public DateTime[] SelectedDates
        {
            get { return UnWrap().SelectedDates; }
            set { UnWrap().SelectedDates = value; }
        }

        public string SelectedDatesAsString
        {
            get { return UnWrap().SelectedDatesAsString; }
            set { UnWrap().SelectedDatesAsString = value; }
        }
    }
}