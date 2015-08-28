using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlButton : HtmlControl<CUITControls.HtmlButton>
    {
        public HtmlButton(CUITControls.HtmlButton sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.HtmlButton(), searchProperties)
        {
        }
    }
}