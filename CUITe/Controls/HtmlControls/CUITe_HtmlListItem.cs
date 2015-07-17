using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlListItem : CUITe_HtmlCustom
    {
        private const string _tagName = "li";

        public CUITe_HtmlListItem(string searchParameters = null)
            : base(_tagName, searchParameters)
        {
        }
    }
}
