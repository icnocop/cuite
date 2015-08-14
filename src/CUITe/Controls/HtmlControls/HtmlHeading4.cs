using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlHeading4 : HtmlCustom
    {
        private const string _tagName = "h4";

        public HtmlHeading4(string searchParameters = null)
            : base(_tagName, searchParameters)
        {
        }
    }
}