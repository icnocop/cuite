#if SILVERLIGHT_SUPPORT
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightImage.
    /// </summary>
    public class SilverlightImage : SilverlightControl<CUITControls.SilverlightImage>
    {
        public SilverlightImage(CUITControls.SilverlightImage sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.SilverlightImage(), searchProperties)
        {
        }
    }
}
#endif