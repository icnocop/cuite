using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfTabPage
    /// </summary>
    public class WpfTabPage : WpfControl<CUITControls.WpfTabPage>
    {
        public WpfTabPage(By searchConfiguration = null)
            : this(new CUITControls.WpfTabPage(), searchConfiguration)
        {
        }

        public WpfTabPage(CUITControls.WpfTabPage sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        public string Header
        {
            get { return SourceControl.Header; }
        }
    }
}