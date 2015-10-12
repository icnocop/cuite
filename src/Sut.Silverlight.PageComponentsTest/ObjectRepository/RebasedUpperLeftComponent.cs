using CUITe.Controls.SilverlightControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.Silverlight.PageComponentsTest.ObjectRepository
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