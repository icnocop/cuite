using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinText
    /// </summary>
    public class WinText : WinControl<CUITControls.WinText>
    {
        public WinText(By searchConfiguration = null)
            : this(new CUITControls.WinText(), searchConfiguration)
        {
        }

        public WinText(CUITControls.WinText sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        public string DisplayText
        {
            get { return SourceControl.DisplayText; }
        }
    }
}