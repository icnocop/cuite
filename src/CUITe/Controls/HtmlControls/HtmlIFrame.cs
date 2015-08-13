using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlIFrame : HtmlControl<CUITControls.HtmlIFrame>
    {
        public HtmlIFrame() : base() { }
        public HtmlIFrame(string searchParameters) : base(searchParameters) { }
    }
}
