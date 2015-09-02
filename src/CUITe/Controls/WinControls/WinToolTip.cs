using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinToolTip
    /// </summary>
    public class WinToolTip : WinControl<CUITControls.WinToolTip>
    {
        public WinToolTip(By searchConfiguration = null)
            : this(new CUITControls.WinToolTip(), searchConfiguration)
        {
        }

        public WinToolTip(CUITControls.WinToolTip sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}