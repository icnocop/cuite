using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinTitleBar
    /// </summary>
    public class CUITe_WinTitleBar : CUITe_WinControl<WinTitleBar>
    {
        public CUITe_WinTitleBar() : base() { }
        public CUITe_WinTitleBar(string searchParameters) : base(searchParameters) { }

        public string DisplayText
        {
            get { return this.UnWrap().DisplayText; }
        }
    }
}