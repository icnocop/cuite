using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfButton
    /// </summary>
    public class WpfButton : WpfControl<CUITControls.WpfButton>
    {
        public WpfButton(string searchProperties = null)
            : this(new CUITControls.WpfButton(), searchProperties)
        {
        }

        public WpfButton(CUITControls.WpfButton sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }

        public string DisplayText
        {
            get { return SourceControl.DisplayText; }
        }
    }
}