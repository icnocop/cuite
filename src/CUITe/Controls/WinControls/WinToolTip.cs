using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinToolTip
    /// </summary>
    public class WinToolTip : WinControl<CUITControls.WinToolTip>
    {
        public WinToolTip() : base() { }
        public WinToolTip(string searchParameters) : base(searchParameters) { }
    }
}