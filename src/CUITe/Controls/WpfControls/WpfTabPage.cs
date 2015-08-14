using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfTabPage
    /// </summary>
    public class WpfTabPage : WpfControl<CUITControls.WpfTabPage>
    {
        public WpfTabPage() { }
        public WpfTabPage(string searchParameters) : base(searchParameters) { }

        public string Header
        {
            get { return UnWrap().Header; }
        }
    }
}