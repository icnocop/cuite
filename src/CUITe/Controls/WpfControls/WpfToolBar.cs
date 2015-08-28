using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfToolBar
    /// </summary>
    public class WpfToolBar : WpfControl<CUITControls.WpfToolBar>
    {
        public WpfToolBar(string searchProperties = null)
            : this(new CUITControls.WpfToolBar(), searchProperties)
        {
        }

        public WpfToolBar(CUITControls.WpfToolBar sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
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