using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfCustom
    /// </summary>
    public class WpfCustom : WpfControl<CUITControls.WpfCustom>
    {
        public WpfCustom(By searchConfiguration = null)
            : this(new CUITControls.WpfCustom(), searchConfiguration)
        {
        }

        public WpfCustom(CUITControls.WpfCustom sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}