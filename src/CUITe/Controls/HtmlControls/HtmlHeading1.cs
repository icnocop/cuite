using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlHeading1 : HtmlCustom
    {
        private const string _tagName = "h1";

        public HtmlHeading1(string searchParameters = null)
            : base(_tagName, searchParameters)
        {
        }
    }
}
