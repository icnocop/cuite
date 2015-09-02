using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfImage
    /// </summary>
    public class WpfImage : WpfControl<CUITControls.WpfImage>
    {
        public WpfImage(By searchConfiguration = null)
            : this(new CUITControls.WpfImage(), searchConfiguration)
        {
        }

        public WpfImage(CUITControls.WpfImage sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        public string Alt
        {
            get { return SourceControl.Alt; }
        }
    }
}