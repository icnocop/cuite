using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlIFrame : HtmlControl<CUITControls.HtmlIFrame>
    {
        public HtmlIFrame()
        {
        }

        public HtmlIFrame(string searchParameters)
            : base(searchParameters)
        {
        }
    }
}