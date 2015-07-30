using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfTabPage
    /// </summary>
    public class CUITe_WpfTabPage : CUITe_WpfControl<WpfTabPage>
    {
        public CUITe_WpfTabPage() : base() { }
        public CUITe_WpfTabPage(string searchParameters) : base(searchParameters) { }

        public string Header
        {
            get { return this.UnWrap().Header; }
        }
    }
}