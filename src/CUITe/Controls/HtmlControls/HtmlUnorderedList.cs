namespace CUITe.Controls.HtmlControls
{
    public class HtmlUnorderedList : HtmlCustom
    {
        private const string _tagName = "ul";

        public HtmlUnorderedList(string searchParameters = null)
            : base(_tagName, searchParameters)
        {
        }
    }
}