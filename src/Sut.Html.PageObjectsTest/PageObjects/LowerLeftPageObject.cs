using CUITe.Controls.HtmlControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.Html.PageObjectsTest.PageObjects
{
    public class LowerLeftPageObject : PageObject
    {
        public bool RadioButtonExists
        {
            get { return Find<HtmlRadioButton>(By.Id("lowerleft")).Exists; }
        }
    }
}