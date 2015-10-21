using CUITe.Controls.HtmlControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.Html.PageComponentsTest.ObjectRepository
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