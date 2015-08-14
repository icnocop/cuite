using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlButton : HtmlControl<CUITControls.HtmlButton>
    {
        public HtmlButton() { }
        public HtmlButton(string searchParameters) : base(searchParameters) { }
    }
}
