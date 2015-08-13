using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfToolTip
    /// </summary>
    public class WpfToolTip : WpfControl<CUITControls.WpfToolTip>
    {
        public WpfToolTip() : base() { }
        public WpfToolTip(string searchParameters) : base(searchParameters) { }
    }
}