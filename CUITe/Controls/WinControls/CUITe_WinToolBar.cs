using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WpfToolBar
    /// </summary>
    public class CUITe_WinToolBar : CUITe_WinControl<WinToolBar>
    {
        public CUITe_WinToolBar() : base() { }
        public CUITe_WinToolBar(string searchParameters) : base(searchParameters) { }

        public UITestControlCollection Items
        {
            get { return this.UnWrap().Items; }
        }
    }
}