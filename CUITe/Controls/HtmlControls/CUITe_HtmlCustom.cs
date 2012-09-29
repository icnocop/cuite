using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlCustom : CUITe_HtmlControl<HtmlCustom>
    {
        public CUITe_HtmlCustom(string tagName)
            : base()
        {
            Initialize(tagName);
        }

        public CUITe_HtmlCustom(string tagName, string searchParameters)
            : base(searchParameters)
        {
            Initialize(tagName);
        }

        private void Initialize(string tagName)
        {
            this.SearchProperties.Add(HtmlControl.PropertyNames.TagName, tagName, PropertyExpressionOperator.EqualTo);
        }
    }
}
