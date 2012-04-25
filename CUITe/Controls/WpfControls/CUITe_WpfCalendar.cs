using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfCalendar
    /// </summary>
    public class CUITe_WpfCalendar : CUITe_WpfControl<WpfCalendar>
    {
        public CUITe_WpfCalendar() : base() { }
        public CUITe_WpfCalendar(string sSearchParameters) : base(sSearchParameters) { }

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