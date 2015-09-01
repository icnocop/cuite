using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinPane
    /// </summary>
    public class WinPane : WinControl<CUITControls.WinPane>
    {
        public WinPane(string searchProperties = null)
            : this(new CUITControls.WinPane(), searchProperties)
        {
        }

        public WinPane(CUITControls.WinPane sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }
    }
}