using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlCell : HtmlControl<CUITControls.HtmlCell>
    {
        public HtmlCell(By searchConfiguration = null)
            : this(new CUITControls.HtmlCell(), searchConfiguration)
        {
        }

        public HtmlCell(CUITControls.HtmlCell sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}