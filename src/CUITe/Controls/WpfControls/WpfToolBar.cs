using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfToolBar
    /// </summary>
    public class WpfToolBar : WpfControl<CUITControls.WpfToolBar>
    {
        public WpfToolBar(By searchConfiguration = null)
            : this(new CUITControls.WpfToolBar(), searchConfiguration)
        {
        }

        public WpfToolBar(CUITControls.WpfToolBar sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        public string Header
        {
            get { return SourceControl.Header; }
        }

        public UITestControlCollection Items
        {
            get { return SourceControl.Items; }
        }
    }
}