using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinStatusBar
    /// </summary>
    public class CUITe_WinStatusBar : CUITe_WinControl<WinStatusBar>
    {
        public CUITe_WinStatusBar() : base() { }
        public CUITe_WinStatusBar(string searchParameters) : base(searchParameters) { }

        public UITestControlCollection Panels
        {
            get { return this.UnWrap().Panels; }
        }
    }
}