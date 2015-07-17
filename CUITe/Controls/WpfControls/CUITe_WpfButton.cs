using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfButton
    /// </summary>
    public class CUITe_WpfButton : CUITe_WpfControl<WpfButton>
    {
        public CUITe_WpfButton() : base() { }
        public CUITe_WpfButton(string searchParameters) : base(searchParameters) { }

        public string DisplayText { get { return this.UnWrap().DisplayText; } }

    }
}