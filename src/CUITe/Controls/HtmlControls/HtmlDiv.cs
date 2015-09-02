using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlDiv : HtmlControl<CUITControls.HtmlDiv>
    {
        public HtmlDiv(By searchConfiguration = null)
            : this(new CUITControls.HtmlDiv(), searchConfiguration)
        {
        }

        public HtmlDiv(CUITControls.HtmlDiv sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}