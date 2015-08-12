using System.Windows.Forms;
using CUIT = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinCalendar
    /// </summary>
    public class WinCalendar : WinControl<CUIT.WinCalendar>
    {
        public WinCalendar() : base() { }
        public WinCalendar(string searchParameters) : base(searchParameters) { }

        public SelectionRange SelectionRange
        {
            get { return this.UnWrap().SelectionRange; }
            set { this.UnWrap().SelectionRange = value; }
        }

        public string SelectionRangeAsString
        {
            get { return this.UnWrap().SelectionRangeAsString; }
            set { this.UnWrap().SelectionRangeAsString = value; }
        }
    }
}