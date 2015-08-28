using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlDiv : HtmlControl<CUITControls.HtmlDiv>
    {
        public HtmlDiv(string searchProperties = null)
            : this(new CUITControls.HtmlDiv(), searchProperties)
        {
        }

        public HtmlDiv(CUITControls.HtmlDiv sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }
    }
}