using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinHyperLink
    /// </summary>
    public class WinHyperlink : WinControl<CUITControls.WinHyperlink>
    {
        public WinHyperlink(By searchConfiguration = null)
            : this(new CUITControls.WinHyperlink(), searchConfiguration)
        {
        }

        public WinHyperlink(CUITControls.WinHyperlink sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        public string DisplayText
        {
            get { return SourceControl.DisplayText; }
        }
    }
}