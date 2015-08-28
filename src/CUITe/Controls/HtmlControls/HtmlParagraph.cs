using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlParagraph : HtmlCustom
    {
        private const string _tagName = "p";

        public HtmlParagraph(CUITControls.HtmlCustom sourceControl = null, string searchProperties = null)
            : base(_tagName, sourceControl, searchProperties)
        {
        }
    }
}