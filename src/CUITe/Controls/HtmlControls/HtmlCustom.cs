using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlCustom : HtmlControl<CUITControls.HtmlCustom>
    {
        public HtmlCustom(string tagName, CUITControls.HtmlCustom sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.HtmlCustom(), searchProperties)
        {
            SearchProperties.Add(CUITControls.HtmlControl.PropertyNames.TagName, tagName, PropertyExpressionOperator.EqualTo);
        }
    }
}