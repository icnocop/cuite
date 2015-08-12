#if SILVERLIGHT_SUPPORT
using CUIT = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightImage.
    /// </summary>
    public class SilverlightImage : SilverlightControl<CUIT.SilverlightImage>
    {
        public SilverlightImage() : base() { }
        public SilverlightImage(string searchParameters) : base(searchParameters) { }
    }
}
#endif