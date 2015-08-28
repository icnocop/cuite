using System.Windows.Forms;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinCalendar
    /// </summary>
    public class WinCalendar : WinControl<CUITControls.WinCalendar>
    {
        public WinCalendar(CUITControls.WinCalendar sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.WinCalendar(), searchProperties)
        {
        }

        public SelectionRange SelectionRange
        {
            get { return SourceControl.SelectionRange; }
            set { SourceControl.SelectionRange = value; }
        }

        public string SelectionRangeAsString
        {
            get { return SourceControl.SelectionRangeAsString; }
            set { SourceControl.SelectionRangeAsString = value; }
        }
    }
}