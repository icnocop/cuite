using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinText
    /// </summary>
    public class WinText : WinControl<CUITControls.WinText>
    {
        public WinText() { }
        public WinText(string searchParameters) : base(searchParameters) { }

        public string DisplayText
        {
            get { return UnWrap().DisplayText; }
        }
    }
}
