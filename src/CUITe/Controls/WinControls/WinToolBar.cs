using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WpfToolBar
    /// </summary>
    public class WinToolBar : WinControl<CUITControls.WinToolBar>
    {
        public WinToolBar(By searchConfiguration = null)
            : this(new CUITControls.WinToolBar(), searchConfiguration)
        {
        }

        public WinToolBar(CUITControls.WinToolBar sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        public UITestControlCollection Items
        {
            get { return SourceControl.Items; }
        }
    }
}