using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinButton
    /// </summary>
    public class WinButton : WinControl<CUITControls.WinButton>
    {
        public WinButton()
        {
        }

        public WinButton(string searchParameters)
            : base(searchParameters)
        {
        }

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