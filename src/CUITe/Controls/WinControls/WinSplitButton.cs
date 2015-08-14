using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinSplitButton
    /// </summary>
    public class WinSplitButton : WinControl<CUITControls.WinSplitButton>
    {
        public WinSplitButton() { }
        public WinSplitButton(string searchParameters) : base(searchParameters) { }

        public string DisplayText
        {
            get { return UnWrap().DisplayText; }
        }

        public string Shortcut
        {
            get { return UnWrap().Shortcut; }
        }
    }
}