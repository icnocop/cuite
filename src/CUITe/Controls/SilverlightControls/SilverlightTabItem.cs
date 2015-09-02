using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

#if SILVERLIGHT_SUPPORT
namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightTabItem.
    /// </summary>
    public class SilverlightTabItem : SilverlightControl<CUITControls.SilverlightTabItem>
    {
        public SilverlightTabItem(By searchConfiguration = null)
            : this(new CUITControls.SilverlightTabItem(), searchConfiguration)
        {
        }

        public SilverlightTabItem(CUITControls.SilverlightTabItem sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}
#endif