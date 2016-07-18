using CUITe.Controls.SilverlightControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.Silverlight.PageObjectsTest.PageObjects
{
    public class RebasedLowerLeftPageObject : PageObject<SilverlightTab>
    {
        public RebasedLowerLeftPageObject()
            : base(By.AutomationId("6B4YMUMZz0CAxPbskr1MgQ"))
        {
        }

        public bool RadioButtonExists
        {
            get { return Find<SilverlightRadioButton>(By.AutomationId("R96eNzWZrUeCOUOiCb5qEQ")).Exists; }
        }
    }
}