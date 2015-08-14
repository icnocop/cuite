using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinTitleBar
    /// </summary>
    public class WinTitleBar : WinControl<CUITControls.WinTitleBar>
    {
        public WinTitleBar() : base() { }
        public WinTitleBar(string searchParameters) : base(searchParameters) { }

        public string DisplayText
        {
            get { return UnWrap().DisplayText; }
        }
    }
}