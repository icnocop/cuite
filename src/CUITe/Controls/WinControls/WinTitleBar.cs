using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinTitleBar
    /// </summary>
    public class WinTitleBar : WinControl<CUITControls.WinTitleBar>
    {
        public WinTitleBar(By searchConfiguration = null)
            : this(new CUITControls.WinTitleBar(), searchConfiguration)
        {
        }

        public WinTitleBar(CUITControls.WinTitleBar sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        public string DisplayText
        {
            get { return SourceControl.DisplayText; }
        }
    }
}