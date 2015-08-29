using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlHeading1 : HtmlCustom
    {
        private const string TagName = "h1";

        public HtmlHeading1(string searchProperties = null)
            : this(new CUITControls.HtmlCustom(), searchProperties)
        {
        }

        public HtmlHeading1(CUITControls.HtmlCustom sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
            AddSearchProperty(CUITControls.HtmlControl.PropertyNames.TagName, TagName);
        }
    }
}