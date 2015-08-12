#if SILVERLIGHT_SUPPORT
using CUIT = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightTree.
    /// </summary>
    public class SilverlightTree : SilverlightControl<CUIT.SilverlightTree>
    {
        public SilverlightTree() : base() { }
        public SilverlightTree(string searchParameters) : base(searchParameters) { }
    }
}
#endif