using CUITe.Controls.HtmlControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.Html.PageObjectsTest.PageObjects
{
    public class RebasedUpperRightPageObject : PageObject<HtmlDiv>
    {
        public RebasedUpperRightPageObject()
            : base(By.Id("upperdiv"))
        {
        }

        public bool CheckBoxExists
        {
            get { return Find<HtmlCheckBox>(By.Id("upperright")).Exists; }
        }
    }
}