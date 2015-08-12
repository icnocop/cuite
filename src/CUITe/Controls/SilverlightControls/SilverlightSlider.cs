#if SILVERLIGHT_SUPPORT
using CUIT = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightSlider.
    /// </summary>
    public class SilverlightSlider : SilverlightControl<CUIT.SilverlightSlider>
    {
        public SilverlightSlider() : base() { }
        public SilverlightSlider(string searchParameters) : base(searchParameters) { }
    }
}
#endif