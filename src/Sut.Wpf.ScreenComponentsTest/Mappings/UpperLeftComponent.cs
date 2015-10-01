using CUITe.Controls.WpfControls;
using CUITe.Mappings;
using CUITe.SearchConfigurations;

namespace Sut.Wpf.ScreenComponentsTest.Mappings
{
    public class UpperLeftComponent : ScreenComponent
    {
        public bool CheckBoxExists
        {
            get { return Find<WpfCheckBox>(By.AutomationId("Ax9iHEo2gk-ayRFljKt2sA")).Exists; }
        }
    }
}