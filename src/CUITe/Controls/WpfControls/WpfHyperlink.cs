using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfHyperlink
    /// </summary>
    public class WpfHyperlink : WpfControl<CUITControls.WpfHyperlink>
    {
        public WpfHyperlink()
        {
        }

        public WpfHyperlink(string searchParameters)
            : base(searchParameters)
        {
        }

        public string Alt
        {
            get { return UnWrap().Alt; }
        }
    }
}