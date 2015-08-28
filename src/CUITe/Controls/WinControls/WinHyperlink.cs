using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinHyperLink
    /// </summary>
    public class WinHyperlink : WinControl<CUITControls.WinHyperlink>
    {
        public WinHyperlink(string searchProperties = null)
            : this(new CUITControls.WinHyperlink(), searchProperties)
        {
        }

        public WinHyperlink(CUITControls.WinHyperlink sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }

        public string DisplayText
        {
            get { return SourceControl.DisplayText; }
        }
    }
}