using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinText
    /// </summary>
    public class WinText : WinControl<CUITControls.WinText>
    {
        public WinText(string searchProperties = null)
            : this(new CUITControls.WinText(), searchProperties)
        {
        }

        public WinText(CUITControls.WinText sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }

        public string DisplayText
        {
            get { return SourceControl.DisplayText; }
        }
    }
}