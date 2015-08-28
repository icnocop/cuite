using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlSpan : HtmlControl<CUITControls.HtmlSpan>
    {
        public HtmlSpan(CUITControls.HtmlSpan sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.HtmlSpan(), searchProperties)
        {
        }
    }
}