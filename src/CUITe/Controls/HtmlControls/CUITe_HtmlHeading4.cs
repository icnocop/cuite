using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlHeading4 : CUITe_HtmlCustom
    {
        private const string _tagName = "h4";

        public CUITe_HtmlHeading4(string searchParameters = null)
            : base(_tagName, searchParameters)
        {
        }
    }
}
