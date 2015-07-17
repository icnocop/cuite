using Microsoft.VisualStudio.TestTools.UITesting.WinControls;


namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinText
    /// </summary>
    public class CUITe_WinText : CUITe_WinControl<WinText>
    {
        public CUITe_WinText() : base() { }
        public CUITe_WinText(string searchParameters) : base(searchParameters) { }

        public string DisplayText
        {
            get { return this.UnWrap().DisplayText; }
        }
    }
}
