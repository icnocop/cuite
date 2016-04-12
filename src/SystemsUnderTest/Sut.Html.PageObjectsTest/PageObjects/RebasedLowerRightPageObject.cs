using CUITe.Controls.HtmlControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.Html.PageObjectsTest.PageObjects
{
    public class RebasedLowerRightPageObject : PageObject<HtmlDiv>
    {
        public RebasedLowerRightPageObject()
            : base(By.Id("lowerdiv"))
        {
        }

        public bool RadioButtonExists
        {
            get { return Find<HtmlRadioButton>(By.Id("lowerright")).Exists; }
        }
    }
}