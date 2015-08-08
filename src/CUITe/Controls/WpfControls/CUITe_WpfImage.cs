using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfImage
    /// </summary>
    public class CUITe_WpfImage : CUITe_WpfControl<WpfImage>
    {
        public CUITe_WpfImage() : base() { }
        public CUITe_WpfImage(string searchParameters) : base(searchParameters) { }

        public string Alt
        {
            get { return this.UnWrap().Alt; }
        }
    }
}