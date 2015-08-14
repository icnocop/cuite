#if SILVERLIGHT_SUPPORT
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightTabItem.
    /// </summary>
    public class SilverlightTabItem : SilverlightControl<CUITControls.SilverlightTabItem>
    {
        public SilverlightTabItem() { }
        public SilverlightTabItem(string searchParameters) : base(searchParameters) { }
    }
}
#endif