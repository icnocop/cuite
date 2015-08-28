#if SILVERLIGHT_SUPPORT
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightSlider.
    /// </summary>
    public class SilverlightSlider : SilverlightControl<CUITControls.SilverlightSlider>
    {
        public SilverlightSlider(CUITControls.SilverlightSlider sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.SilverlightSlider(), searchProperties)
        {
        }
    }
}
#endif