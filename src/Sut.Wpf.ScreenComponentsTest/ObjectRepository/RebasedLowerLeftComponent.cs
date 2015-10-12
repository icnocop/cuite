using CUITe.Controls.WpfControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.Wpf.ScreenComponentsTest.ObjectRepository
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