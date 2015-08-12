using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinPane
    /// </summary>
    public class WinPane : WinControl<CUITControls.WinPane>
    {
        public WinPane() : base() { }
        public WinPane(string searchParameters) : base(searchParameters) { }
    }
}