using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinPane
    /// </summary>
    public class WinPane : WinControl<CUITControls.WinPane>
    {
        public WinPane(CUITControls.WinPane sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.WinPane(), searchProperties)
        {
        }
    }
}