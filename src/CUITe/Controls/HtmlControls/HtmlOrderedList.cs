using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlOrderedList : HtmlCustom
    {
        private const string _tagName = "ol";

        public HtmlOrderedList(string searchParameters = null)
            : base(_tagName, searchParameters)
        {
        }
    }
}
