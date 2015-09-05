using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlListItem : HtmlCustom
    {
        public HtmlListItem(By searchConfiguration = null)
            : this(new CUITControls.HtmlCustom(), searchConfiguration)
        {
        }

        public HtmlListItem(CUITControls.HtmlCustom sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}