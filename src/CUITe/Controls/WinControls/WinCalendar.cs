using System.Windows.Forms;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinCalendar
    /// </summary>
    public class WinCalendar : WinControl<CUITControls.WinCalendar>
    {
        public WinCalendar() : base() { }
        public WinCalendar(string searchParameters) : base(searchParameters) { }

        public SelectionRange SelectionRange
        {
            get { return UnWrap().SelectionRange; }
            set { UnWrap().SelectionRange = value; }
        }

        public string SelectionRangeAsString
        {
            get { return UnWrap().SelectionRangeAsString; }
            set { UnWrap().SelectionRangeAsString = value; }
        }
    }
}