using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlHyperlink : HtmlControl<CUITControls.HtmlHyperlink>
    {
        public HtmlHyperlink(CUITControls.HtmlHyperlink sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.HtmlHyperlink(), searchProperties)
        {
        }
    }
}