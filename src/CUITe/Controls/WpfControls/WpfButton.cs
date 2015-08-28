using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfButton
    /// </summary>
    public class WpfButton : WpfControl<CUITControls.WpfButton>
    {
        public WpfButton(CUITControls.WpfButton sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.WpfButton(), searchProperties)
        {
        }

        public string DisplayText
        {
            get { return SourceControl.DisplayText; }
        }
    }
}