using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlHeading4 : CUITe_HtmlCustom
    {
        private const string _tagName = "h4";

        public CUITe_HtmlHeading4()
            : base(_tagName)
        {
        }

        public CUITe_HtmlHeading4(string searchParameters)
            : base(_tagName, searchParameters)
        {
        }
    }
}
