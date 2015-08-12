using CUIT = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinPane
    /// </summary>
    public class WinPane : WinControl<CUIT.WinPane>
    {
        public WinPane() : base() { }
        public WinPane(string searchParameters) : base(searchParameters) { }
    }
}