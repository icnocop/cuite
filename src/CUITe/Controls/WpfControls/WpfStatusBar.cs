using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfStatusBar
    /// </summary>
    public class WpfStatusBar : WpfControl<CUITControls.WpfStatusBar>
    {
        public WpfStatusBar() : base() { }
        public WpfStatusBar(string searchParameters) : base(searchParameters) { }

        public UITestControlCollection Panels
        {
            get { return this.UnWrap().Panels; }
        }
    }
}