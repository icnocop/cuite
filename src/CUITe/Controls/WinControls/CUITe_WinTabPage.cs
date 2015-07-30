using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinTabPage
    /// </summary>
    public class CUITe_WinTabPage : CUITe_WinControl<WinTabPage>
    {
        public CUITe_WinTabPage() : base() { }
        public CUITe_WinTabPage(string searchParameters) : base(searchParameters) { }

        public string DisplayText
        {
            get { return this.UnWrap().DisplayText; }
        }
    }
}