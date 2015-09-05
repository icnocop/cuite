using System;
using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfDatePicker
    /// </summary>
    public class WpfDatePicker : WpfControl<CUITControls.WpfDatePicker>
    {
        public WpfDatePicker(By searchConfiguration = null)
            : this(new CUITControls.WpfDatePicker(), searchConfiguration)
        {
        }

        public WpfDatePicker(CUITControls.WpfDatePicker sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        public WpfCalendar Calendar
        {
            get
            {
                WpfCalendar calendar = new WpfCalendar((CUITControls.WpfCalendar)SourceControl.Calendar);
                return calendar;
            }
        }

        public DateTime Date
        {
            get { return SourceControl.Date; }
            set { SourceControl.Date = value; }
        }

        public string DateAsString
        {
            get { return SourceControl.DateAsString; }
            set { SourceControl.DateAsString = value; }
        }

        public bool ShowCalendar
        {
            get { return SourceControl.ShowCalendar; }
            set { SourceControl.ShowCalendar = value; }
        }
    }
}