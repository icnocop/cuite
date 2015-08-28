#if SILVERLIGHT_SUPPORT
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightHyperlink.
    /// </summary>
    public class SilverlightHyperlink : SilverlightControl<CUITControls.SilverlightHyperlink>
    {
        public SilverlightHyperlink(string searchProperties = null)
            : this(new CUITControls.SilverlightHyperlink(), searchProperties)
        {
        }

        public SilverlightHyperlink(CUITControls.SilverlightHyperlink sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }
    }
}
#endif