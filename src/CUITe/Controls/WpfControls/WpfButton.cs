using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfButton
    /// </summary>
    public class WpfButton : WpfControl<CUITControls.WpfButton>
    {
        public WpfButton(By searchConfiguration = null)
            : this(new CUITControls.WpfButton(), searchConfiguration)
        {
        }

        public WpfButton(CUITControls.WpfButton sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        public string DisplayText
        {
            get { return SourceControl.DisplayText; }
        }
    }
}