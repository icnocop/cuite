using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlXml : HtmlCustom
    {
        private const string TagName = "xml";

        public HtmlXml(By searchConfiguration = null)
            : this(new CUITControls.HtmlCustom(), searchConfiguration)
        {
        }

        public HtmlXml(CUITControls.HtmlCustom sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
            AddSearchProperty(CUITControls.HtmlControl.PropertyNames.TagName, TagName);
        }
    }
}