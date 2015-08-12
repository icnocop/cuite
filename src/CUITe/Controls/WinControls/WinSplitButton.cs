using CUIT = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinSplitButton
    /// </summary>
    public class WinSplitButton : WinControl<CUIT.WinSplitButton>
    {
        public WinSplitButton() : base() { }
        public WinSplitButton(string searchParameters) : base(searchParameters) { }

        public string DisplayText
        {
            get { return this.UnWrap().DisplayText; }
        }

        public string Shortcut
        {
            get { return this.UnWrap().Shortcut; }
        }
    }
}