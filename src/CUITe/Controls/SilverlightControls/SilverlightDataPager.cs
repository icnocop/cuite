#if SILVERLIGHT_SUPPORT
using CUIT = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightDataPager.
    /// </summary>
    public class SilverlightDataPager : SilverlightControl<CUIT.SilverlightDataPager>
    {
        public SilverlightDataPager() : base() { }
        public SilverlightDataPager(string searchParameters) : base(searchParameters) { }
    }
}
#endif