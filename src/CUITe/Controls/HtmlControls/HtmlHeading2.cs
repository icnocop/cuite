using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlHeading2 : HtmlCustom
    {
        private const string _tagName = "h2";

        public HtmlHeading2(string searchParameters = null)
            : base(_tagName, searchParameters)
        {
        }
    }
}
