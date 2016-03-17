using CUITe.Controls.HtmlControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.Html.PageObjectsTest.PageObjects
{
    public class RebasedLowerLeftPageObject : PageObject<HtmlDiv>
    {
        public RebasedLowerLeftPageObject()
            : base(By.Id("lowerdiv"))
        {
        }

        public bool RadioButtonExists
        {
            get { return Find<HtmlRadioButton>(By.Id("lowerleft")).Exists; }
        }
    }
}