using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlIns : CUITe_HtmlControl<HtmlCustom>
    {
        public CUITe_HtmlIns()
            : base()
        {
            Initialize();
        }

        public CUITe_HtmlIns(string searchParameters)
            : base(searchParameters)
        {
            Initialize();
        }

        private void Initialize()
        {
            this.SearchProperties.Add(HtmlControl.PropertyNames.TagName, "ins", PropertyExpressionOperator.EqualTo);
        }
    }
}
