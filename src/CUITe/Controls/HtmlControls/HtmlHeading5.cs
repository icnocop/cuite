using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlHeading5 : CUITe_HtmlCustom
    {
        private const string _tagName = "h5";

        public CUITe_HtmlHeading5(string searchParameters = null)
            : base(_tagName, searchParameters)
        {
        }
    }
}
