using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public abstract class HtmlControl : ControlBase<CUITControls.HtmlControl>
    {
        protected HtmlControl(string tagName, CUITControls.HtmlControl sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.HtmlControl(), searchProperties)
        {
            AddSearchProperty(CUITControls.HtmlControl.PropertyNames.TagName, tagName);
        }
    }
}