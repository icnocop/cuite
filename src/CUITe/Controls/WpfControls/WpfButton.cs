using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfButton
    /// </summary>
    public class WpfButton : WpfControl<CUITControls.WpfButton>
    {
        public WpfButton() { }
        public WpfButton(string searchParameters) : base(searchParameters) { }

        public string DisplayText { get { return UnWrap().DisplayText; } }

    }
}