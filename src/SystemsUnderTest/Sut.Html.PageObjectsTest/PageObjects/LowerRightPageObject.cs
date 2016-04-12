using CUITe.Controls.HtmlControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.Html.PageObjectsTest.PageObjects
{
    public class LowerRightPageObject : PageObject
    {
        public bool RadioButtonExists
        {
            get { return Find<HtmlRadioButton>(By.Id("lowerright")).Exists; }
        }
    }
}