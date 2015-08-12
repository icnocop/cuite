#if SILVERLIGHT_SUPPORT
using CUIT = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightHyperlink.
    /// </summary>
    public class SilverlightHyperlink : SilverlightControl<CUIT.SilverlightHyperlink>
    {
        public SilverlightHyperlink() : base() { }
        public SilverlightHyperlink(string searchParameters) : base(searchParameters) { }
    }
}
#endif