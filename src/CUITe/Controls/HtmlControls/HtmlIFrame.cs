using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlIFrame : HtmlControl<CUITControls.HtmlIFrame>
    {
        public HtmlIFrame(CUITControls.HtmlIFrame sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.HtmlIFrame(), searchProperties)
        {
        }
    }
}