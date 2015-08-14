#if SILVERLIGHT_SUPPORT
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightSlider.
    /// </summary>
    public class SilverlightSlider : SilverlightControl<CUITControls.SilverlightSlider>
    {
        public SilverlightSlider() { }
        public SilverlightSlider(string searchParameters) : base(searchParameters) { }
    }
}
#endif