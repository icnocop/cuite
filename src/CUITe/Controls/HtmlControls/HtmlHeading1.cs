using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlHeading1 : HtmlCustom
    {
        private const string TagName = "h1";

        public HtmlHeading1(By searchConfiguration = null)
            : this(new CUITControls.HtmlCustom(), searchConfiguration)
        {
        }

        public HtmlHeading1(CUITControls.HtmlCustom sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
            AddSearchProperty(CUITControls.HtmlControl.PropertyNames.TagName, TagName);
        }
    }
}