using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinSplitButton
    /// </summary>
    public class WinSplitButton : WinControl<CUITControls.WinSplitButton>
    {
        public WinSplitButton(CUITControls.WinSplitButton sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.WinSplitButton(), searchProperties)
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