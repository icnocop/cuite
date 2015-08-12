#if SILVERLIGHT_SUPPORT
using CUIT = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightTabItem.
    /// </summary>
    public class SilverlightTabItem : SilverlightControl<CUIT.SilverlightTabItem>
    {
        public SilverlightTabItem() : base() { }
        public SilverlightTabItem(string searchParameters) : base(searchParameters) { }
    }
}
#endif