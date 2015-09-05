using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinSplitButton
    /// </summary>
    public class WinSplitButton : WinControl<CUITControls.WinSplitButton>
    {
        public WinSplitButton(By searchConfiguration = null)
            : this(new CUITControls.WinSplitButton(), searchConfiguration)
        {
        }

        public WinSplitButton(CUITControls.WinSplitButton sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        public string DisplayText
        {
            get { return SourceControl.DisplayText; }
        }

        public string Shortcut
        {
            get { return SourceControl.Shortcut; }
        }
    }
}