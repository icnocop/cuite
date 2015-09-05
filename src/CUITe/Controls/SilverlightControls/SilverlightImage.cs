#if SILVERLIGHT_SUPPORT
using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightImage.
    /// </summary>
    public class SilverlightImage : SilverlightControl<CUITControls.SilverlightImage>
    {
        public SilverlightImage(By searchConfiguration = null)
            : this(new CUITControls.SilverlightImage(), searchConfiguration)
        {
        }

        public SilverlightImage(CUITControls.SilverlightImage sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}
#endif