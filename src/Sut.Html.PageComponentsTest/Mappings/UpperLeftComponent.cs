using CUITe.Controls.HtmlControls;
using CUITe.Mappings;
using CUITe.SearchConfigurations;

namespace Sut.Html.PageComponentsTest.Mappings
{
    public class UpperLeftComponent : PageComponent
    {
        public bool CheckBoxExists
        {
            get { return Find<HtmlCheckBox>(By.Id("upperleft")).Exists; }
        }
    }
}