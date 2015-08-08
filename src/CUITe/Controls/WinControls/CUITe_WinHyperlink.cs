using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinHyperLink
    /// </summary>
    public class CUITe_WinHyperlink : CUITe_WinControl<WinHyperlink>
    {
        public CUITe_WinHyperlink() : base() { }
        public CUITe_WinHyperlink(string searchParameters) : base(searchParameters) { }

        public string DisplayText
        {
            get { return this.UnWrap().DisplayText; }
        }
    }
}