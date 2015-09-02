using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfPane
    /// </summary>
    public class WpfPane : WpfControl<CUITControls.WpfPane>
    {
        public WpfPane(By searchConfiguration = null)
            : this(new CUITControls.WpfPane(), searchConfiguration)
        {
        }

        public WpfPane(CUITControls.WpfPane sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}