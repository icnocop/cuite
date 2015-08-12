using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlListItem : HtmlCustom
    {
        private const string _tagName = "li";

        public HtmlListItem(string searchParameters = null)
            : base(_tagName, searchParameters)
        {
        }
    }
}
