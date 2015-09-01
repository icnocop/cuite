using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlRow : HtmlControl<CUITControls.HtmlRow>
    {
        public HtmlRow(string searchProperties = null)
            : this(new CUITControls.HtmlRow(), searchProperties)
        {
        }

        public HtmlRow(CUITControls.HtmlRow sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }
    }
}