using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlHyperlink : HtmlControl<CUITControls.HtmlHyperlink>
    {
        public HtmlHyperlink() : base() { }
        public HtmlHyperlink(string searchParameters) : base(searchParameters) { }
    }
}
