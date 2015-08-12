using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlOrderedList : CUITe_HtmlCustom
    {
        private const string _tagName = "ol";

        public CUITe_HtmlOrderedList(string searchParameters = null)
            : base(_tagName, searchParameters)
        {
        }
    }
}
