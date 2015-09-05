using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlHeading2 : HtmlCustom
    {
        private const string TagName = "h2";

        public HtmlHeading2(By searchConfiguration = null)
            : this(new CUITControls.HtmlCustom(), searchConfiguration)
        {
        }

        public HtmlHeading2(CUITControls.HtmlCustom sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
            AddSearchProperty(CUITControls.HtmlControl.PropertyNames.TagName, TagName);
        }
    }
}