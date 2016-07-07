using CUITe.Controls.SilverlightControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.Silverlight.PageObjectsTest.PageObjects
{
    public class RebasedUpperLeftPageObject : PageObject<SilverlightTab>
    {
        public RebasedUpperLeftPageObject()
            : base(By.AutomationId("YATJVQnvMk6SNHFQAHb9CQ"))
        {
        }

        public bool CheckBoxExists
        {
            get { return Find<SilverlightCheckBox>(By.AutomationId("Pb67nqNzdkKZPTz-cUXtTQ")).Exists; }
        }
    }
}