using CUITe.Controls.HtmlControls;
using CUITe.Mappings;
using CUITe.SearchConfigurations;

namespace Sut.Html.PageComponentsTest.Mappings
{
    public class UpperRightComponent : PageComponent
    {
        public bool CheckBoxExists
        {
            get { return Find<HtmlCheckBox>(By.Id("upperright")).Exists; }
        }
    }
}