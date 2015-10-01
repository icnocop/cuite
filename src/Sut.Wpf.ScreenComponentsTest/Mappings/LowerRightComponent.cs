using CUITe.Controls.WpfControls;
using CUITe.Mappings;
using CUITe.SearchConfigurations;

namespace Sut.Wpf.ScreenComponentsTest.Mappings
{
    public class LowerRightComponent : ScreenComponent
    {
        public bool RadioButtonExists
        {
            get { return Find<WpfRadioButton>(By.AutomationId("oEOhLBF5ske3yGfbHhThuA")).Exists; }
        }
    }
}