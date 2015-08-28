using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinHyperLink
    /// </summary>
    public class WinHyperlink : WinControl<CUITControls.WinHyperlink>
    {
        public WinHyperlink(CUITControls.WinHyperlink sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.WinHyperlink(), searchProperties)
        {
        }

        public string DisplayText
        {
            get { return SourceControl.DisplayText; }
        }
    }
}