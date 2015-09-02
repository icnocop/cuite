using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfToolTip
    /// </summary>
    public class WpfToolTip : WpfControl<CUITControls.WpfToolTip>
    {
        public WpfToolTip(By searchConfiguration = null)
            : this(new CUITControls.WpfToolTip(), searchConfiguration)
        {
        }

        public WpfToolTip(CUITControls.WpfToolTip sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}