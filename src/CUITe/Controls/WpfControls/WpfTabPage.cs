using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfTabPage
    /// </summary>
    public class WpfTabPage : WpfControl<CUITControls.WpfTabPage>
    {
        public WpfTabPage(string searchProperties = null)
            : this(new CUITControls.WpfTabPage(), searchProperties)
        {
        }

        public WpfTabPage(CUITControls.WpfTabPage sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }

        public string Header
        {
            get { return SourceControl.Header; }
        }
    }
}