using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinTabPage
    /// </summary>
    public class WinTabPage : WinControl<CUITControls.WinTabPage>
    {
        public WinTabPage(CUITControls.WinTabPage sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.WinTabPage(), searchProperties)
        {
        }

        public string DisplayText
        {
            get { return SourceControl.DisplayText; }
        }
    }
}