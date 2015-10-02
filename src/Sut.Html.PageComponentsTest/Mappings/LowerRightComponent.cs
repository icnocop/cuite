using CUITe.Controls.HtmlControls;
using CUITe.Mappings;
using CUITe.SearchConfigurations;

namespace Sut.Html.PageComponentsTest.Mappings
{
    public class LowerRightComponent : PageComponent
    {
        public bool RadioButtonExists
        {
            get { return Find<HtmlRadioButton>(By.Id("lowerright")).Exists; }
        }
    }
}