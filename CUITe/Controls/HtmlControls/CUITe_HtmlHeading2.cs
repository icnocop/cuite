using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlHeading2 : CUITe_HtmlControl<HtmlCustom>
    {
        public CUITe_HtmlHeading2()
            : base()
        {
            Initialize();
        }

        public CUITe_HtmlHeading2(string searchParameters)
            : base(searchParameters)
        {
            Initialize();
        }

        private void Initialize()
        {
            this.SearchProperties.Add(HtmlControl.PropertyNames.TagName, "h2", PropertyExpressionOperator.EqualTo);
        }
    }
}
