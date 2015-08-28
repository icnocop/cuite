using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfTitleBar
    /// </summary>
    public class WpfTitleBar : WpfControl<CUITControls.WpfTitleBar>
    {
        public WpfTitleBar(string searchProperties = null)
            : this(new CUITControls.WpfTitleBar(), searchProperties)
        {
        }

        public WpfTitleBar(CUITControls.WpfTitleBar sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }

        public string DisplayText
        {
            get { return SourceControl.DisplayText; }
        }
    }
}