using CUITe.Controls.WpfControls;
using CUITe.Mappings;
using CUITe.SearchConfigurations;

namespace Sut.Wpf.ScreenComponentsTest.Mappings
{
    public class LowerLeftComponent : ScreenComponent
    {
        public bool RadioButtonExists
        {
            get { return Find<WpfRadioButton>(By.AutomationId("U-nw96CGFUuMrbKg3h0tCQ")).Exists; }
        }
    }
}