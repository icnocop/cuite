using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfImage
    /// </summary>
    public class WpfImage : WpfControl<CUITControls.WpfImage>
    {
        public WpfImage() { }
        public WpfImage(string searchParameters) : base(searchParameters) { }

        public string Alt
        {
            get { return UnWrap().Alt; }
        }
    }
}