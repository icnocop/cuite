using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlDiv : HtmlControl<CUITControls.HtmlDiv>
    {
        public HtmlDiv() : base() { }
        public HtmlDiv(string searchParameters) : base(searchParameters) { }
    }
}
