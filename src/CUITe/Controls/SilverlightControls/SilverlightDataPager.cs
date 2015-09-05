#if SILVERLIGHT_SUPPORT
using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightDataPager.
    /// </summary>
    public class SilverlightDataPager : SilverlightControl<CUITControls.SilverlightDataPager>
    {
        public SilverlightDataPager(By searchConfiguration = null)
            : this(new CUITControls.SilverlightDataPager(), searchConfiguration)
        {
        }

        public SilverlightDataPager(CUITControls.SilverlightDataPager sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}
#endif