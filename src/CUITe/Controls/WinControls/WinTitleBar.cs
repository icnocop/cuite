using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinTitleBar
    /// </summary>
    public class WinTitleBar : WinControl<CUITControls.WinTitleBar>
    {
        public WinTitleBar(string searchProperties = null)
            : this(new CUITControls.WinTitleBar(), searchProperties)
        {
        }

        public WinTitleBar(CUITControls.WinTitleBar sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }

        public string DisplayText
        {
            get { return SourceControl.DisplayText; }
        }
    }
}