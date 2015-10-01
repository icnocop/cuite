using CUITe.Controls.WpfControls;
using CUITe.Mappings;
using CUITe.SearchConfigurations;

namespace Sut.Wpf.ScreenComponentsTest.Mappings
{
    public class UpperRightComponent : ScreenComponent
    {
        public bool CheckBoxExists
        {
            get { return Find<WpfCheckBox>(By.AutomationId("C_-kLEiiN0Odz20KncjQJQ")).Exists; }
        }
    }
}