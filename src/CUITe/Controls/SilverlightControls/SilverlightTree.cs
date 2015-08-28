#if SILVERLIGHT_SUPPORT
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightTree.
    /// </summary>
    public class SilverlightTree : SilverlightControl<CUITControls.SilverlightTree>
    {
        public SilverlightTree(string searchProperties = null)
            : this(new CUITControls.SilverlightTree(), searchProperties)
        {
        }

        public SilverlightTree(CUITControls.SilverlightTree sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }
    }
}
#endif