using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlUnorderedList : HtmlCustom
    {
        private const string _tagName = "ul";

        public HtmlUnorderedList(CUITControls.HtmlCustom sourceControl = null, string searchProperties = null)
            : base(_tagName, sourceControl, searchProperties)
        {
        }
    }
}