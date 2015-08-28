using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlRow : HtmlControl<CUITControls.HtmlRow>
    {
        public HtmlRow(CUITControls.HtmlRow sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.HtmlRow(), searchProperties)
        {
        }
    }
}