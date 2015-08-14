#if SILVERLIGHT_SUPPORT
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightHyperlink.
    /// </summary>
    public class SilverlightHyperlink : SilverlightControl<CUITControls.SilverlightHyperlink>
    {
        public SilverlightHyperlink() { }
        public SilverlightHyperlink(string searchParameters) : base(searchParameters) { }
    }
}
#endif