using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlHeaderCell : HtmlControl<CUITControls.HtmlHeaderCell>
    {
        public HtmlHeaderCell(CUITControls.HtmlHeaderCell sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.HtmlHeaderCell(), searchProperties)
        {
        }
    }
}