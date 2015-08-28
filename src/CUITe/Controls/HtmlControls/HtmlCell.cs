using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlCell : HtmlControl<CUITControls.HtmlCell>
    {
        public HtmlCell(CUITControls.HtmlCell sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.HtmlCell(), searchProperties)
        {
        }
    }
}