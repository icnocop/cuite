using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinDateTimePicker
    /// </summary>
    public class WinDateTimePicker : WinControl<CUITControls.WinDateTimePicker>
    {
        public WinDateTimePicker() : base() { }
        public WinDateTimePicker(string searchParameters) : base(searchParameters) { }

        public UITestControl Calendar
        {
            get { return this.UnWrap().Calendar; }
        }

        public WinCalendar CalendarAsCUITe
        {
            get
            {
                WinCalendar calendar = new WinCalendar();
                calendar.WrapReady(this.UnWrap().Calendar);
                return calendar;
            }
        }

        public DateTime DateTime
        {
            get { return this.UnWrap().DateTime; }
            set { this.UnWrap().DateTime = value; }
        }

        public string DateTimeAsString
        {
            get { return this.UnWrap().DateTimeAsString; }
            set { this.UnWrap().DateTimeAsString = value; }
        }

        public DateTimePickerFormat Format
        {
            get { return this.UnWrap().Format; }
        }

        public bool HasCheckBox
        {
            get { return this.UnWrap().HasCheckBox; }
        }

        public bool HasDropDownButton
        {
            get { return this.UnWrap().HasDropDownButton; }
        }

        public bool HasSpinner
        {
            get { return this.UnWrap().HasSpinner; }
        }

        public bool ShowCalendar
        {
            get { return this.UnWrap().ShowCalendar; }
            set { this.UnWrap().ShowCalendar = value; }
        }

    }
}