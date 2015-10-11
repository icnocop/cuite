using CUITe.Controls.HtmlControls;
using CUITe.Mappings;
using CUITe.SearchConfigurations;

namespace Sut.Html.PageComponentsTest.Mappings
{
    public class RebasedLowerRightComponent : PageComponent<HtmlDiv>
    {
        public RebasedLowerRightComponent()
            : base(By.Id("lowerdiv"))
        {
        }

        public bool RadioButtonExists
        {
            get { return Find<HtmlRadioButton>(By.Id("lowerright")).Exists; }
        }
    }
}