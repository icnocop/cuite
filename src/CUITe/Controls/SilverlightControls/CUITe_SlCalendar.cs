using System;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightCalendar.
    /// </summary>
    public class CUITe_SlCalendar : CUITe_SlControl<SilverlightCalendar>
    {
        public CUITe_SlCalendar() : base() { }
        public CUITe_SlCalendar(string searchParameters) : base(searchParameters) { }

        public System.Windows.Forms.SelectionRange SelectedDateRange
        {
            set
            {
                this._control.WaitForControlReady();
                this._control.SelectedDateRange = value;
            }
        }

        public string SelectedDateRangeAsString
        {
            set
            {
                this._control.WaitForControlReady();
                this._control.SelectedDateRangeAsString = value;
            }
        }

        public int SelectionMode
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.SelectionMode;
            }
        }

        public DateTime[] SelectedDates
        {
            get 
            {
                this._control.WaitForControlReady();
                return this._control.SelectedDates;
            }
            set
            {
                this._control.WaitForControlReady();
                this._control.SelectedDates = value;
            }
        }

        public string SelectedDatesAsString
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.SelectedDatesAsString;
            }
            set
            {
                this._control.WaitForControlReady();
                this._control.SelectedDatesAsString = value;
            }
        }
    }
}
