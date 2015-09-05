using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlButton : HtmlControl<CUITControls.HtmlButton>
    {
        public HtmlButton(By searchConfiguration = null)
            : this(new CUITControls.HtmlButton(), searchConfiguration)
        {
        }

        public HtmlButton(CUITControls.HtmlButton sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}