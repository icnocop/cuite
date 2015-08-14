using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlParagraph : HtmlCustom
    {
        private const string _tagName = "p";

        public HtmlParagraph(string searchParameters = null)
            : base(_tagName, searchParameters)
        {
        }
    }
}