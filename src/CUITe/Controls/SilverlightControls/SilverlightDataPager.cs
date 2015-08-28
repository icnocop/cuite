#if SILVERLIGHT_SUPPORT
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightDataPager.
    /// </summary>
    public class SilverlightDataPager : SilverlightControl<CUITControls.SilverlightDataPager>
    {
        public SilverlightDataPager(string searchProperties = null)
            : this(new CUITControls.SilverlightDataPager(), searchProperties)
        {
        }

        public SilverlightDataPager(CUITControls.SilverlightDataPager sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }
    }
}
#endif