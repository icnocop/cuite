using CUITe.Controls.HtmlControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.Html.PageComponentsTest.ObjectRepository
{
    public class UpperLeftComponent : PageComponent
    {
        public bool CheckBoxExists
        {
            get { return Find<HtmlCheckBox>(By.Id("upperleft")).Exists; }
        }
    }
}