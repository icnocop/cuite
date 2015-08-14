using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlHeading3 : HtmlCustom
    {
        private const string _tagName = "h3";

        public HtmlHeading3(string searchParameters = null)
            : base(_tagName, searchParameters)
        {
        }
    }
}