using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlIFrame : HtmlControl<CUITControls.HtmlIFrame>
    {
        public HtmlIFrame(By searchConfiguration = null)
            : this(new CUITControls.HtmlIFrame(), searchConfiguration)
        {
        }

        public HtmlIFrame(CUITControls.HtmlIFrame sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}