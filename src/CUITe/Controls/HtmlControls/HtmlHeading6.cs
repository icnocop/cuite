using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlHeading6 : HtmlCustom
    {
        private const string _tagName = "h6";

        public HtmlHeading6(string searchParameters = null)
            : base(_tagName, searchParameters)
        {
        }
    }
}
