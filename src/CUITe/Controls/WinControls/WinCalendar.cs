using System.Windows.Forms;
using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinCalendar
    /// </summary>
    public class WinCalendar : WinControl<CUITControls.WinCalendar>
    {
        public WinCalendar(By searchConfiguration = null)
            : this(new CUITControls.WinCalendar(), searchConfiguration)
        {
        }

        public WinCalendar(CUITControls.WinCalendar sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
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