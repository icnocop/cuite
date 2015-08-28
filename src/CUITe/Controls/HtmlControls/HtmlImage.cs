using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlImage : HtmlControl<CUITControls.HtmlImage>
    {
        public HtmlImage(string searchProperties = null)
            : this(new CUITControls.HtmlImage(), searchProperties)
        {
        }

        public HtmlImage(CUITControls.HtmlImage sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }
    }
}