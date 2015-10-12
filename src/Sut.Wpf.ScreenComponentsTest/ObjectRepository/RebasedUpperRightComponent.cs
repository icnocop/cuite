using CUITe.Controls.WpfControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.Wpf.ScreenComponentsTest.ObjectRepository
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