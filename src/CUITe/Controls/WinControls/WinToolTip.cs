using CUIT = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinToolTip
    /// </summary>
    public class WinToolTip : WinControl<CUIT.WinToolTip>
    {
        public WinToolTip() : base() { }
        public WinToolTip(string searchParameters) : base(searchParameters) { }
    }
}