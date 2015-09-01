using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlHeaderCell : HtmlControl<CUITControls.HtmlHeaderCell>
    {
        public HtmlHeaderCell(string searchProperties = null)
            : this(new CUITControls.HtmlHeaderCell(), searchProperties)
        {
        }

        public HtmlHeaderCell(CUITControls.HtmlHeaderCell sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }
    }
}