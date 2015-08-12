using CUIT = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinTitleBar
    /// </summary>
    public class WinTitleBar : WinControl<CUIT.WinTitleBar>
    {
        public WinTitleBar() : base() { }
        public WinTitleBar(string searchParameters) : base(searchParameters) { }

        public string DisplayText
        {
            get { return this.UnWrap().DisplayText; }
        }
    }
}