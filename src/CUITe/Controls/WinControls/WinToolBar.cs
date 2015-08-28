using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WpfToolBar
    /// </summary>
    public class WinToolBar : WinControl<CUITControls.WinToolBar>
    {
        public WinToolBar(string searchProperties = null)
            : this(new CUITControls.WinToolBar(), searchProperties)
        {
        }

        public WinToolBar(CUITControls.WinToolBar sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }

        public UITestControlCollection Items
        {
            get { return SourceControl.Items; }
        }
    }
}