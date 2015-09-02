using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinPane
    /// </summary>
    public class WinPane : WinControl<CUITControls.WinPane>
    {
        public WinPane(By searchConfiguration = null)
            : this(new CUITControls.WinPane(), searchConfiguration)
        {
        }

        public WinPane(CUITControls.WinPane sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}