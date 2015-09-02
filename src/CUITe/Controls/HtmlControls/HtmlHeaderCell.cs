using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlHeaderCell : HtmlControl<CUITControls.HtmlHeaderCell>
    {
        public HtmlHeaderCell(By searchConfiguration = null)
            : this(new CUITControls.HtmlHeaderCell(), searchConfiguration)
        {
        }

        public HtmlHeaderCell(CUITControls.HtmlHeaderCell sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}