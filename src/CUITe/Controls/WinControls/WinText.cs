using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinText
    /// </summary>
    public class WinText : WinControl<CUITControls.WinText>
    {
        public WinText(CUITControls.WinText sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.WinText(), searchProperties)
        {
        }

        public string DisplayText
        {
            get { return SourceControl.DisplayText; }
        }
    }
}