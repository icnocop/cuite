#if SILVERLIGHT_SUPPORT
using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightTree.
    /// </summary>
    public class SilverlightTree : SilverlightControl<CUITControls.SilverlightTree>
    {
        public SilverlightTree(By searchConfiguration = null)
            : this(new CUITControls.SilverlightTree(), searchConfiguration)
        {
        }

        public SilverlightTree(CUITControls.SilverlightTree sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}
#endif