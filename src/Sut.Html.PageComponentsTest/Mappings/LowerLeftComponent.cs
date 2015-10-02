using CUITe.Controls.HtmlControls;
using CUITe.Mappings;
using CUITe.SearchConfigurations;

namespace Sut.Html.PageComponentsTest.Mappings
{
    public class LowerLeftComponent : PageComponent
    {
        public bool RadioButtonExists
        {
            get { return Find<HtmlRadioButton>(By.Id("lowerleft")).Exists; }
        }
    }
}