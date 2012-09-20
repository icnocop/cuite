using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlListItem : CUITe_HtmlControl<HtmlCustom>
    {
        public CUITe_HtmlListItem()
            : base()
        {
            Initialize();
        }

        public CUITe_HtmlListItem(string searchParameters)
            : base(searchParameters)
        {
            Initialize();
        }

        private void Initialize()
        {
            this.SearchProperties.Add(HtmlControl.PropertyNames.TagName, "li", PropertyExpressionOperator.EqualTo);
        }
    }
}
