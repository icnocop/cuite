using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfSeparator
    /// </summary>
    public class WpfSeparator : WpfControl<CUITControls.WpfSeparator>
    {
        public WpfSeparator(By searchConfiguration = null)
            : this(new CUITControls.WpfSeparator(), searchConfiguration)
        {
        }

        public WpfSeparator(CUITControls.WpfSeparator sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}