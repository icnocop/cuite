using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlXml : CUITe_HtmlCustom
    {
        private const string _tagName = "xml";

        public CUITe_HtmlXml()
            : base(_tagName)
        {
        }

        public CUITe_HtmlXml(string searchParameters)
            : base(_tagName, searchParameters)
        {
        }
    }
}
