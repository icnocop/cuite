using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfTitleBar
    /// </summary>
    public class WpfTitleBar : WpfControl<CUITControls.WpfTitleBar>
    {
        public WpfTitleBar(By searchConfiguration = null)
            : this(new CUITControls.WpfTitleBar(), searchConfiguration)
        {
        }

        public WpfTitleBar(CUITControls.WpfTitleBar sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        public string DisplayText
        {
            get { return SourceControl.DisplayText; }
        }
    }
}