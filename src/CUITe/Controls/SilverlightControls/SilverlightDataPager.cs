#if SILVERLIGHT_SUPPORT
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightDataPager.
    /// </summary>
    public class SilverlightDataPager : SilverlightControl<CUITControls.SilverlightDataPager>
    {
        public SilverlightDataPager()
        {
        }

        public SilverlightDataPager(string searchParameters)
            : base(searchParameters)
        {
        }
    }
}
#endif