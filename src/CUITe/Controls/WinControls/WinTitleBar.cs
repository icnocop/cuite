using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinTitleBar
    /// </summary>
    public class WinTitleBar : WinControl<CUITControls.WinTitleBar>
    {
        public WinTitleBar(CUITControls.WinTitleBar sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.WinTitleBar(), searchProperties)
        {
        }

        public string DisplayText
        {
            get { return SourceControl.DisplayText; }
        }
    }
}