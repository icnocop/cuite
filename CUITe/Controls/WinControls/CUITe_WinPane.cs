using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinPane
    /// </summary>
    public class CUITe_WinPane : CUITe_WinControl<WinPane>
    {
        public CUITe_WinPane() : base() { }
        public CUITe_WinPane(string searchParameters) : base(searchParameters) { }
    }
}