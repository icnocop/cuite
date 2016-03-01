using CUITe.Controls.HtmlControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.Html.PageObjectsTest.PageObjects
{
    public class UpperRightPageObject : PageObject
    {
        public bool CheckBoxExists
        {
            get { return Find<HtmlCheckBox>(By.Id("upperright")).Exists; }
        }
    }
}