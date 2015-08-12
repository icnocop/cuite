using CUIT = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfButton
    /// </summary>
    public class WpfButton : WpfControl<CUIT.WpfButton>
    {
        public WpfButton() : base() { }
        public WpfButton(string searchParameters) : base(searchParameters) { }

        public string DisplayText { get { return this.UnWrap().DisplayText; } }

    }
}