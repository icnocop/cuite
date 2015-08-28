using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinStatusBar
    /// </summary>
    public class WinStatusBar : WinControl<CUITControls.WinStatusBar>
    {
        public WinStatusBar(CUITControls.WinStatusBar sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.WinStatusBar(), searchProperties)
        {
        }

        public UITestControlCollection Panels
        {
            get { return SourceControl.Panels; }
        }
    }
}