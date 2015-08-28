using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlImage : HtmlControl<CUITControls.HtmlImage>
    {
        public HtmlImage(CUITControls.HtmlImage sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.HtmlImage(), searchProperties)
        {
        }
    }
}