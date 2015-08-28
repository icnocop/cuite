using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlCustom : HtmlControl<CUITControls.HtmlCustom>
    {
        public HtmlCustom(string tagName, CUITControls.HtmlCustom sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.HtmlCustom(), searchProperties)
        {
            AddSearchProperty(CUITControls.HtmlControl.PropertyNames.TagName, tagName);
        }
    }
}