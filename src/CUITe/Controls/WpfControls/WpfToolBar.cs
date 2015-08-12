using Microsoft.VisualStudio.TestTools.UITesting;
using CUIT = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfToolBar
    /// </summary>
    public class WpfToolBar : WpfControl<CUIT.WpfToolBar>
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