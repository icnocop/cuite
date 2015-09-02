using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlHyperlink : HtmlControl<CUITControls.HtmlHyperlink>
    {
        public HtmlHyperlink(By searchConfiguration = null)
            : this(new CUITControls.HtmlHyperlink(), searchConfiguration)
        {
        }

        public HtmlHyperlink(CUITControls.HtmlHyperlink sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}