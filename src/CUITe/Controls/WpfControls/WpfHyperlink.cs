using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfHyperlink
    /// </summary>
    public class WpfHyperlink : WpfControl<CUITControls.WpfHyperlink>
    {
        public WpfHyperlink(string searchProperties = null)
            : this(new CUITControls.WpfHyperlink(), searchProperties)
        {
        }

        public WpfHyperlink(CUITControls.WpfHyperlink sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }

        public string Alt
        {
            get { return SourceControl.Alt; }
        }
    }
}