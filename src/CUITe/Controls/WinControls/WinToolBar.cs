using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WpfToolBar
    /// </summary>
    public class WinToolBar : WinControl<CUITControls.WinToolBar>
    {
        public WinToolBar() { }
        public WinToolBar(string searchParameters) : base(searchParameters) { }

        public UITestControlCollection Items
        {
            get { return UnWrap().Items; }
        }
    }
}