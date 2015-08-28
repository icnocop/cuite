using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfTitleBar
    /// </summary>
    public class WpfTitleBar : WpfControl<CUITControls.WpfTitleBar>
    {
        public WpfTitleBar(CUITControls.WpfTitleBar sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.WpfTitleBar(), searchProperties)
        {
        }

        public string DisplayText
        {
            get { return SourceControl.DisplayText; }
        }
    }
}