using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WpfToolBar
    /// </summary>
    public class WinToolBar : WinControl<CUITControls.WinToolBar>
    {
        public WinToolBar(CUITControls.WinToolBar sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.WinToolBar(), searchProperties)
        {
        }

        public UITestControlCollection Items
        {
            get { return SourceControl.Items; }
        }
    }
}