using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlHeading1 : CUITe_HtmlCustom
    {
        private const string _tagName = "h1";

        public CUITe_HtmlHeading1(string searchParameters = null)
            : base(_tagName, searchParameters)
        {
        }
    }
}
