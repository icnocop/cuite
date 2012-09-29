using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlHeading6 : CUITe_HtmlCustom
    {
        private const string _tagName = "h6";

        public CUITe_HtmlHeading6()
            : base(_tagName)
        {
        }

        public CUITe_HtmlHeading6(string searchParameters)
            : base(_tagName, searchParameters)
        {
        }
    }
}
