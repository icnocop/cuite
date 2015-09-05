using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinCustom
    /// </summary>
    public class WinCustom : WinControl<CUITControls.WinCustom>
    {
        public WinCustom(By searchConfiguration = null)
            : this(new CUITControls.WinCustom(), searchConfiguration)
        {
        }

        public WinCustom(CUITControls.WinCustom sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}