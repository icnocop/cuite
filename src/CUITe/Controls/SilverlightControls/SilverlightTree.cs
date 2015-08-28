#if SILVERLIGHT_SUPPORT
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightTree.
    /// </summary>
    public class SilverlightTree : SilverlightControl<CUITControls.SilverlightTree>
    {
        public SilverlightTree(CUITControls.SilverlightTree sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.SilverlightTree(), searchProperties)
        {
        }
    }
}
#endif