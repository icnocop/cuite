using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public abstract class HtmlControl : ControlBase<CUITControls.HtmlControl>
    {
        protected HtmlControl(string tagName, CUITControls.HtmlControl sourceControl = null, By searchConfiguration = null)
            : base(sourceControl ?? new CUITControls.HtmlControl(), searchConfiguration)
        {
            AddSearchProperty(CUITControls.HtmlControl.PropertyNames.TagName, tagName);
        }
    }
}