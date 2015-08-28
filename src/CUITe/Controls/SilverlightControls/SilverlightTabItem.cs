#if SILVERLIGHT_SUPPORT
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightTabItem.
    /// </summary>
    public class SilverlightTabItem : SilverlightControl<CUITControls.SilverlightTabItem>
    {
        public SilverlightTabItem(string searchProperties = null)
            : this(new CUITControls.SilverlightTabItem(), searchProperties)
        {
        }

        public SilverlightTabItem(CUITControls.SilverlightTabItem sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }
    }
}
#endif