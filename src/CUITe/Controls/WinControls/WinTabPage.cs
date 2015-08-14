using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinTabPage
    /// </summary>
    public class WinTabPage : WinControl<CUITControls.WinTabPage>
    {
        public WinTabPage() { }
        public WinTabPage(string searchParameters) : base(searchParameters) { }

        public string DisplayText
        {
            get { return UnWrap().DisplayText; }
        }
    }
}