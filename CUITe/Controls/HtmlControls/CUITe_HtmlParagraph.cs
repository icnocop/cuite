using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlParagraph : CUITe_HtmlCustom
    {
        private const string _tagName = "p";

        public CUITe_HtmlParagraph()
            : base(_tagName)
        {
        }

        public CUITe_HtmlParagraph(string searchParameters)
            : base(_tagName, searchParameters)
        {
        }
    }
}
