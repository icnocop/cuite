using CUITe.Controls.WpfControls;
using CUITe.Mappings;
using CUITe.SearchConfigurations;

namespace Sut.Wpf.ScreenComponentsTest.Mappings
{
    public class RebasedLowerLeftComponent : ScreenComponent<WpfGroup>
    {
        public RebasedLowerLeftComponent()
            : base(By.AutomationId("fP30sIPPlUSqyjyzfMHKfQ"))
        {
        }

        public bool RadioButtonExists
        {
            get { return Find<WpfRadioButton>(By.AutomationId("U-nw96CGFUuMrbKg3h0tCQ")).Exists; }
        }
    }
}