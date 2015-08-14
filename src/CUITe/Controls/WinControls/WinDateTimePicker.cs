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
            get { return UnWrap().Calendar; }
        }

        public WinCalendar CalendarAsCUITe
        {
            get
            {
                WinCalendar calendar = new WinCalendar();
                calendar.WrapReady(UnWrap().Calendar);
                return calendar;
            }
        }

        public DateTime DateTime
        {
            get { return UnWrap().DateTime; }
            set { UnWrap().DateTime = value; }
        }

        public string DateTimeAsString
        {
            get { return UnWrap().DateTimeAsString; }
            set { UnWrap().DateTimeAsString = value; }
        }

        public DateTimePickerFormat Format
        {
            get { return UnWrap().Format; }
        }

        public bool HasCheckBox
        {
            get { return UnWrap().HasCheckBox; }
        }

        public bool HasDropDownButton
        {
            get { return UnWrap().HasDropDownButton; }
        }

        public bool HasSpinner
        {
            get { return UnWrap().HasSpinner; }
        }

        public bool ShowCalendar
        {
            get { return UnWrap().ShowCalendar; }
            set { UnWrap().ShowCalendar = value; }
        }

    }
}