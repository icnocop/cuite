using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfPane
    /// </summary>
    public class WpfPane : WpfControl<CUITControls.WpfPane>
    {
        public WpfPane() : base() { }
        public WpfPane(string searchParameters) : base(searchParameters) { }
    }
}