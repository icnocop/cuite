using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfText
    /// </summary>
    public class CUITe_WpfText : CUITe_WpfControl<WpfText>
    {
        public CUITe_WpfText() : base() { }
        public CUITe_WpfText(string searchParameters) : base(searchParameters) { }

        public string DisplayText
        {
            get { return this.UnWrap().DisplayText; }
        }
    }
}