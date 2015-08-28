using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfToolBar
    /// </summary>
    public class WpfToolBar : WpfControl<CUITControls.WpfToolBar>
    {
        public WpfToolBar(CUITControls.WpfToolBar sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.WpfToolBar(), searchProperties)
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