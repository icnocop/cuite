using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlCustom : HtmlControl<CUITControls.HtmlCustom>
    {
        // TODO: How do we handle tag name when it comes to the factories where they are mistaken for search properties
        public HtmlCustom(string tagName, CUITControls.HtmlCustom sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.HtmlCustom(), searchProperties)
        {
            AddSearchProperty(CUITControls.HtmlControl.PropertyNames.TagName, tagName);
        }
    }
}