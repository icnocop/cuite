using CUITe.Controls.SilverlightControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.Silverlight.PageObjectsTest.PageObjects
{
    public class LowerRightPageObject : PageObject
    {
        public bool RadioButtonExists
        {
            get { return Find<SilverlightRadioButton>(By.AutomationId("0IZpFrh750Kps3zMlrFFcA")).Exists; }
        }
    }
}