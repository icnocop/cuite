using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfHyperlink
    /// </summary>
    public class WpfHyperlink : WpfControl<CUITControls.WpfHyperlink>
    {
        public WpfHyperlink(By searchConfiguration = null)
            : this(new CUITControls.WpfHyperlink(), searchConfiguration)
        {
        }

        public WpfHyperlink(CUITControls.WpfHyperlink sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        public string Alt
        {
            get { return SourceControl.Alt; }
        }
    }
}