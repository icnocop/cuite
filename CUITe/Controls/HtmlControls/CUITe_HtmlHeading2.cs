using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlHeading2 : CUITe_HtmlCustom
    {
        private const string _tagName = "h2";

        public CUITe_HtmlHeading2()
            : base(_tagName)
        {
        }

        public CUITe_HtmlHeading2(string searchParameters)
            : base(_tagName, searchParameters)
        {
        }
    }
}
