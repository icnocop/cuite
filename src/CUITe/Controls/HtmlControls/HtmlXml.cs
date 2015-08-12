using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlXml : CUITe_HtmlCustom
    {
        private const string _tagName = "xml";

        public CUITe_HtmlXml(string searchParameters = null)
            : base(_tagName, searchParameters)
        {
        }
    }
}
