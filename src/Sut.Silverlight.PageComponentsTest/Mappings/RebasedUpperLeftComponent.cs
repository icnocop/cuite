using CUITe.Controls.SilverlightControls;
using CUITe.Mappings;
using CUITe.SearchConfigurations;

namespace Sut.Silverlight.PageComponentsTest.Mappings
{
    public class RebasedUpperLeftComponent : PageComponent<SilverlightTabItem>
    {
        public RebasedUpperLeftComponent()
            : base(By.AutomationId("YATJVQnvMk6SNHFQAHb9CQ"))
        {
        }

        public bool CheckBoxExists
        {
            get { return Find<SilverlightCheckBox>(By.AutomationId("Pb67nqNzdkKZPTz-cUXtTQ")).Exists; }
        }
    }
}