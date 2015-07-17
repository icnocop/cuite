using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlIns : CUITe_HtmlCustom
    {
        private const string _tagName = "ins";

        public CUITe_HtmlIns(string searchParameters = null)
            : base(_tagName, searchParameters)
        {
        }
    }
}
