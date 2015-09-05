using System;
using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfCalendar
    /// </summary>
    public class WpfCalendar : WpfControl<CUITControls.WpfCalendar>
    {
        public WpfCalendar(By searchConfiguration = null)
            : this(new CUITControls.WpfCalendar(), searchConfiguration)
        {
        }

        public WpfCalendar(CUITControls.WpfCalendar sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
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