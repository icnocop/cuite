using CUITe.Controls.HtmlControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.Html.PageObjectsTest.PageObjects
{
    public class RebasedUpperLeftPageObject : PageObject<HtmlDiv>
    {
        public RebasedUpperLeftPageObject()
            : base(By.Id("upperdiv"))
        {
        }

        public bool CheckBoxExists
        {
            get { return Find<HtmlCheckBox>(By.Id("upperleft")).Exists; }
        }
    }
}