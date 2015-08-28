using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfHyperlink
    /// </summary>
    public class WpfHyperlink : WpfControl<CUITControls.WpfHyperlink>
    {
        public WpfHyperlink(CUITControls.WpfHyperlink sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.WpfHyperlink(), searchProperties)
        {
        }

        public string Alt
        {
            get { return SourceControl.Alt; }
        }
    }
}