using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlPassword : HtmlEdit
    {
        public HtmlPassword(By searchConfiguration = null)
            : this(new CUITControls.HtmlEdit(), searchConfiguration)
        {
        }

        public HtmlPassword(CUITControls.HtmlEdit sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
            AddSearchProperty(CUITControls.HtmlControl.PropertyNames.Type, "PASSWORD");
        }
    }
}