using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlRow : HtmlControl<CUITControls.HtmlRow>
    {
        public HtmlRow(By searchConfiguration = null)
            : this(new CUITControls.HtmlRow(), searchConfiguration)
        {
        }

        public HtmlRow(CUITControls.HtmlRow sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}