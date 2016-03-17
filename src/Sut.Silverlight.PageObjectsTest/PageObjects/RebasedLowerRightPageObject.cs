using CUITe.Controls.SilverlightControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.Silverlight.PageObjectsTest.PageObjects
{
    public class RebasedLowerRightPageObject : PageObject<SilverlightTabItem>
    {
        public RebasedLowerRightPageObject()
            : base(By.AutomationId("vzoWE0pag0S7yk0Wmb9iug"))
        {
        }

        public bool RadioButtonExists
        {
            get { return Find<SilverlightRadioButton>(By.AutomationId("0IZpFrh750Kps3zMlrFFcA")).Exists; }
        }
    }
}