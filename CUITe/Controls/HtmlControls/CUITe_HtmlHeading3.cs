using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlHeading3 : CUITe_HtmlControl<HtmlCustom>
    {
        public CUITe_HtmlHeading3()
            : base()
        {
            Initialize();
        }

        public CUITe_HtmlHeading3(string searchParameters)
            : base(searchParameters)
        {
            Initialize();
        }

        private void Initialize()
        {
            this.SearchProperties.Add(HtmlControl.PropertyNames.TagName, "h3", PropertyExpressionOperator.EqualTo);
        }
    }
}
