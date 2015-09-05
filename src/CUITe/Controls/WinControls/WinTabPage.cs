using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinTabPage
    /// </summary>
    public class WinTabPage : WinControl<CUITControls.WinTabPage>
    {
        public WinTabPage(By searchConfiguration = null)
            : this(new CUITControls.WinTabPage(), searchConfiguration)
        {
        }

        public WinTabPage(CUITControls.WinTabPage sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        public string DisplayText
        {
            get { return SourceControl.DisplayText; }
        }
    }
}