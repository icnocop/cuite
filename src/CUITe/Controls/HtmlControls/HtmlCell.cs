using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlCell : HtmlControl<CUITControls.HtmlCell>
    {
        public HtmlCell(string searchProperties = null)
            : this(new CUITControls.HtmlCell(), searchProperties)
        {
        }

        public HtmlCell(CUITControls.HtmlCell sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }
    }
}