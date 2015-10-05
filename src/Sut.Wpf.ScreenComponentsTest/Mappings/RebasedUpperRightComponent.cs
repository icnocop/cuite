using CUITe.Controls.WpfControls;
using CUITe.Mappings;
using CUITe.SearchConfigurations;

namespace Sut.Wpf.ScreenComponentsTest.Mappings
{
    public class RebasedUpperRightComponent : ScreenComponent<WpfGroup>
    {
        public RebasedUpperRightComponent()
            : base(By.AutomationId("L9Z3HQOziUWAllix8yzsEg"))
        {
        }

        public bool CheckBoxExists
        {
            get { return Find<WpfCheckBox>(By.AutomationId("C_-kLEiiN0Odz20KncjQJQ")).Exists; }
        }
    }
}