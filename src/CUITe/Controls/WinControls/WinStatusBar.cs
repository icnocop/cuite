using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinStatusBar
    /// </summary>
    public class WinStatusBar : WinControl<CUITControls.WinStatusBar>
    {
        public WinStatusBar(By searchConfiguration = null)
            : this(new CUITControls.WinStatusBar(), searchConfiguration)
        {
        }

        public WinStatusBar(CUITControls.WinStatusBar sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        public UITestControlCollection Panels
        {
            get { return SourceControl.Panels; }
        }
    }
}