using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfStatusBar
    /// </summary>
    public class WpfStatusBar : WpfControl<CUITControls.WpfStatusBar>
    {
        public WpfStatusBar(string searchProperties = null)
            : this(new CUITControls.WpfStatusBar(), searchProperties)
        {
        }

        public WpfStatusBar(CUITControls.WpfStatusBar sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }

        public UITestControlCollection Panels
        {
            get { return SourceControl.Panels; }
        }
    }
}