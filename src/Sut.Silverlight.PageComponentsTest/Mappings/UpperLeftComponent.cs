using CUITe.Controls.SilverlightControls;
using CUITe.Mappings;
using CUITe.SearchConfigurations;

namespace Sut.Silverlight.PageComponentsTest.Mappings
{
    public class UpperLeftComponent : PageComponent
    {
        public bool CheckBoxExists
        {
            get { return Find<SilverlightCheckBox>(By.AutomationId("Pb67nqNzdkKZPTz-cUXtTQ")).Exists; }
        }
    }
}