using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinStatusBar
    /// </summary>
    public class WinStatusBar : WinControl<CUITControls.WinStatusBar>
    {
        public WinStatusBar() : base() { }
        public WinStatusBar(string searchParameters) : base(searchParameters) { }

        public UITestControlCollection Panels
        {
            get { return this.UnWrap().Panels; }
        }
    }
}