using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfStatusBar
    /// </summary>
    public class CUITe_WpfStatusBar : CUITe_WpfControl<WpfStatusBar>
    {
        public CUITe_WpfStatusBar() : base() { }
        public CUITe_WpfStatusBar(string searchParameters) : base(searchParameters) { }

        public UITestControlCollection Panels
        {
            get { return this.UnWrap().Panels; }
        }
    }
}