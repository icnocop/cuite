#if SILVERLIGHT_SUPPORT
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightSlider.
    /// </summary>
    public class SilverlightSlider : SilverlightControl<CUITControls.SilverlightSlider>
    {
        public SilverlightSlider(string searchProperties = null)
            : this(new CUITControls.SilverlightSlider(), searchProperties)
        {
        }

        public SilverlightSlider(CUITControls.SilverlightSlider sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }
    }
}
#endif