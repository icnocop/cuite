using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlHeading5 : HtmlCustom
    {
        private const string TagName = "h5";

        public HtmlHeading5(By searchConfiguration = null)
            : this(new CUITControls.HtmlCustom(), searchConfiguration)
        {
        }

        public HtmlHeading5(CUITControls.HtmlCustom sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
            AddSearchProperty(CUITControls.HtmlControl.PropertyNames.TagName, TagName);
        }
    }
}