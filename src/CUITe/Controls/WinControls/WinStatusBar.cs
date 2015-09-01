using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinStatusBar
    /// </summary>
    public class WinStatusBar : WinControl<CUITControls.WinStatusBar>
    {
        public WinStatusBar(string searchProperties = null)
            : this(new CUITControls.WinStatusBar(), searchProperties)
        {
        }

        public WinStatusBar(CUITControls.WinStatusBar sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }

        public UITestControlCollection Panels
        {
            get { return SourceControl.Panels; }
        }
    }
}