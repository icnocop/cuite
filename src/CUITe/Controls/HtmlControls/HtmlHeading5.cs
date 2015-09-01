using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlHeading5 : HtmlCustom
    {
        private const string TagName = "h5";

        public HtmlHeading5(string searchProperties = null)
            : this(new CUITControls.HtmlCustom(), searchProperties)
        {
        }

        public HtmlHeading5(CUITControls.HtmlCustom sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
            AddSearchProperty(CUITControls.HtmlControl.PropertyNames.TagName, TagName);
        }
    }
}