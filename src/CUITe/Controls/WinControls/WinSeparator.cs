using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinSeparator
    /// </summary>
    public class WinSeparator : WinControl<CUITControls.WinSeparator>
    {
        public WinSeparator(By searchConfiguration = null)
            : this(new CUITControls.WinSeparator(), searchConfiguration)
        {
        }

        public WinSeparator(CUITControls.WinSeparator sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}