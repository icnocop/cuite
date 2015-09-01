using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinTabPage
    /// </summary>
    public class WinTabPage : WinControl<CUITControls.WinTabPage>
    {
        public WinTabPage(string searchProperties = null)
            : this(new CUITControls.WinTabPage(), searchProperties)
        {
        }

        public WinTabPage(CUITControls.WinTabPage sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }

        public string DisplayText
        {
            get { return SourceControl.DisplayText; }
        }
    }
}