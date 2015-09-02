using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlSpan : HtmlControl<CUITControls.HtmlSpan>
    {
        public HtmlSpan(By searchConfiguration = null)
            : this(new CUITControls.HtmlSpan(), searchConfiguration)
        {
        }

        public HtmlSpan(CUITControls.HtmlSpan sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}