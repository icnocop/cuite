using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfImage
    /// </summary>
    public class WpfImage : WpfControl<CUITControls.WpfImage>
    {
        public WpfImage(string searchProperties = null)
            : this(new CUITControls.WpfImage(), searchProperties)
        {
        }

        public WpfImage(CUITControls.WpfImage sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }

        public string Alt
        {
            get { return SourceControl.Alt; }
        }
    }
}