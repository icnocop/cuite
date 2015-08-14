using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlImage : HtmlControl<CUITControls.HtmlImage>
    {
        public HtmlImage()
        {
        }

        public HtmlImage(string searchParameters)
            : base(searchParameters)
        {
        }
    }
}