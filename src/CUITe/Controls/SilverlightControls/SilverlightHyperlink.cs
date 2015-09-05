#if SILVERLIGHT_SUPPORT
using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightHyperlink.
    /// </summary>
    public class SilverlightHyperlink : SilverlightControl<CUITControls.SilverlightHyperlink>
    {
        public SilverlightHyperlink(By searchConfiguration = null)
            : this(new CUITControls.SilverlightHyperlink(), searchConfiguration)
        {
        }

        public SilverlightHyperlink(CUITControls.SilverlightHyperlink sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}
#endif