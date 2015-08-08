using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfTitleBar
    /// </summary>
    public class CUITe_WpfTitleBar : CUITe_WpfControl<WpfTitleBar>
    {
        public CUITe_WpfTitleBar() : base() { }
        public CUITe_WpfTitleBar(string searchParameters) : base(searchParameters) { }

        public string DisplayText
        {
            get { return this.UnWrap().DisplayText; }
        }
    }
}