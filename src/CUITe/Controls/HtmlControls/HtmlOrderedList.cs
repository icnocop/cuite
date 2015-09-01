using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlOrderedList : HtmlCustom
    {
        private const string TagName = "ol";

        public HtmlOrderedList(string searchProperties = null)
            : this(new CUITControls.HtmlCustom(), searchProperties)
        {
        }

        public HtmlOrderedList(CUITControls.HtmlCustom sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
            AddSearchProperty(CUITControls.HtmlControl.PropertyNames.TagName, TagName);
        }
    }
}