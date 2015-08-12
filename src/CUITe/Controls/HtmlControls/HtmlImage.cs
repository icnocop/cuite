using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlImage : HtmlControl<CUITControls.HtmlImage>
    {
        public HtmlImage() : base() { }
        public HtmlImage(string searchParameters) : base(searchParameters) { }
    }
}
