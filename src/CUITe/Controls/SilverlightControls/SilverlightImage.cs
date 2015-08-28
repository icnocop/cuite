#if SILVERLIGHT_SUPPORT
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightImage.
    /// </summary>
    public class SilverlightImage : SilverlightControl<CUITControls.SilverlightImage>
    {
        public SilverlightImage(string searchProperties = null)
            : this(new CUITControls.SilverlightImage(), searchProperties)
        {
        }

        public SilverlightImage(CUITControls.SilverlightImage sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }
    }
}
#endif