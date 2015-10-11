using CUITe.Controls.HtmlControls;
using CUITe.Mappings;
using CUITe.SearchConfigurations;

namespace Sut.Html.PageComponentsTest.Mappings
{
    public class RebasedUpperRightComponent : PageComponent<HtmlDiv>
    {
        public RebasedUpperRightComponent()
            : base(By.Id("upperdiv"))
        {
        }

        public bool CheckBoxExists
        {
            get { return Find<HtmlCheckBox>(By.Id("upperright")).Exists; }
        }
    }
}