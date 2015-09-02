using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfText
    /// </summary>
    public class WpfText : WpfControl<CUITControls.WpfText>
    {
        public WpfText(By searchConfiguration = null)
            : this(new CUITControls.WpfText(), searchConfiguration)
        {
        }

        public WpfText(CUITControls.WpfText sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        public string DisplayText
        {
            get { return SourceControl.DisplayText; }
        }
    }
}