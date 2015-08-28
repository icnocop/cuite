using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfImage
    /// </summary>
    public class WpfImage : WpfControl<CUITControls.WpfImage>
    {
        public WpfImage(CUITControls.WpfImage sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.WpfImage(), searchProperties)
        {
        }

        public string Alt
        {
            get { return SourceControl.Alt; }
        }
    }
}