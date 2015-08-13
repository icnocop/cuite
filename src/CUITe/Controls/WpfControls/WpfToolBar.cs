using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfToolBar
    /// </summary>
    public class WpfToolBar : WpfControl<CUITControls.WpfToolBar>
    {
        public WpfToolBar() : base() { }
        public WpfToolBar(string searchParameters) : base(searchParameters) { }

        public string Header
        {
            get { return this.UnWrap().Header; }
        }

        public UITestControlCollection Items
        {
            get { return this.UnWrap().Items; }
        }
    }
}