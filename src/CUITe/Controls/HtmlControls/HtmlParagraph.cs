using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlParagraph : HtmlCustom
    {
        private const string _tagName = "p";

        public HtmlParagraph(string searchProperties = null)
            : this(new CUITControls.HtmlCustom(), searchProperties)
        {
        }

        public HtmlParagraph(CUITControls.HtmlCustom sourceControl, string searchProperties = null)
            : base(_tagName, sourceControl, searchProperties)
        {
        }
    }
}