#if SILVERLIGHT_SUPPORT
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightTabItem.
    /// </summary>
    public class SilverlightTabItem : SilverlightControl<CUITControls.SilverlightTabItem>
    {
        public SilverlightTabItem(CUITControls.SilverlightTabItem sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.SilverlightTabItem(), searchProperties)
        {
        }
    }
}
#endif