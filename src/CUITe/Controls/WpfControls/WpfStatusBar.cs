using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfStatusBar
    /// </summary>
    public class WpfStatusBar : WpfControl<CUITControls.WpfStatusBar>
    {
        public WpfStatusBar(CUITControls.WpfStatusBar sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.WpfStatusBar(), searchProperties)
        {
        }

        public UITestControlCollection Panels
        {
            get { return SourceControl.Panels; }
        }
    }
}