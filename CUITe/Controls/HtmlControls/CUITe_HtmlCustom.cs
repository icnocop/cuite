using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlCustom : CUITe_HtmlControl<HtmlCustom>
    {
        public CUITe_HtmlCustom(string tagName)
            : base()
        {
            this.SearchProperties.Add(HtmlControl.PropertyNames.TagName, tagName, PropertyExpressionOperator.EqualTo);
        }
    }
}
