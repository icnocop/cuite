using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfTabPage
    /// </summary>
    public class WpfTabPage : WpfControl<CUITControls.WpfTabPage>
    {
        public WpfTabPage(CUITControls.WpfTabPage sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.WpfTabPage(), searchProperties)
        {
        }

        public string Header
        {
            get { return SourceControl.Header; }
        }
    }
}