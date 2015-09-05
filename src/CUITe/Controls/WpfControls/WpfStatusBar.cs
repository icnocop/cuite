using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfStatusBar
    /// </summary>
    public class WpfStatusBar : WpfControl<CUITControls.WpfStatusBar>
    {
        public WpfStatusBar(By searchConfiguration = null)
            : this(new CUITControls.WpfStatusBar(), searchConfiguration)
        {
        }

        public WpfStatusBar(CUITControls.WpfStatusBar sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        public UITestControlCollection Panels
        {
            get { return SourceControl.Panels; }
        }
    }
}