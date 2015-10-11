using CUITe.Controls.HtmlControls;
using CUITe.Mappings;
using CUITe.SearchConfigurations;

namespace Sut.Html.PageComponentsTest.Mappings
{
    public class RebasedUpperLeftComponent : PageComponent<HtmlDiv>
    {
        public RebasedUpperLeftComponent()
            : base(By.Id("upperdiv"))
        {
        }

        public bool CheckBoxExists
        {
            get { return Find<HtmlCheckBox>(By.Id("upperleft")).Exists; }
        }
    }
}