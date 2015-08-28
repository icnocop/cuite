using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinSplitButton
    /// </summary>
    public class WinSplitButton : WinControl<CUITControls.WinSplitButton>
    {
        public WinSplitButton(string searchProperties = null)
            : this(new CUITControls.WinSplitButton(), searchProperties)
        {
        }

        public WinSplitButton(CUITControls.WinSplitButton sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
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