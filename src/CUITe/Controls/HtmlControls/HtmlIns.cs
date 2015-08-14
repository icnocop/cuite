using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlIns : HtmlCustom
    {
        private const string _tagName = "ins";

        public HtmlIns(string searchParameters = null)
            : base(_tagName, searchParameters)
        {
        }
    }
}