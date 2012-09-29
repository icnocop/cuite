using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlHeading3 : CUITe_HtmlCustom
    {
        private const string _tagName = "h3";

        public CUITe_HtmlHeading3()
            : base(_tagName)
        {
        }

        public CUITe_HtmlHeading3(string searchParameters)
            : base(_tagName, searchParameters)
        {
        }
    }
}
