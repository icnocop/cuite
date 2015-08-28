using System;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfCalendar
    /// </summary>
    public class WpfCalendar : WpfControl<CUITControls.WpfCalendar>
    {
        public WpfCalendar(CUITControls.WpfCalendar sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.WpfCalendar(), searchProperties)
        {
        }

        public DateTime[] SelectedDates
        {
            get { return SourceControl.SelectedDates; }
            set { SourceControl.SelectedDates = value; }
        }

        public string SelectedDatesAsString
        {
            get { return SourceControl.SelectedDatesAsString; }
            set { SourceControl.SelectedDatesAsString = value; }
        }
    }
}