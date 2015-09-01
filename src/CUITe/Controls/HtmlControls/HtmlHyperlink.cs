using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlHyperlink : HtmlControl<CUITControls.HtmlHyperlink>
    {
        public HtmlHyperlink(string searchProperties = null)
            : this(new CUITControls.HtmlHyperlink(), searchProperties)
        {
        }

        public HtmlHyperlink(CUITControls.HtmlHyperlink sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }
    }
}