using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlDiv : HtmlControl<CUITControls.HtmlDiv>
    {
        public HtmlDiv(CUITControls.HtmlDiv sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.HtmlDiv(), searchProperties)
        {
        }
    }
}