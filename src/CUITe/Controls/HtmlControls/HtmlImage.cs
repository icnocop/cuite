using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlImage : HtmlControl<CUITControls.HtmlImage>
    {
        public HtmlImage(By searchConfiguration = null)
            : this(new CUITControls.HtmlImage(), searchConfiguration)
        {
        }

        public HtmlImage(CUITControls.HtmlImage sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}