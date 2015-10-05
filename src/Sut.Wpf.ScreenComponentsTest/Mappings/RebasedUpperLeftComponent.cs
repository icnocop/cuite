using CUITe.Controls.WpfControls;
using CUITe.Mappings;
using CUITe.SearchConfigurations;

namespace Sut.Wpf.ScreenComponentsTest.Mappings
{
    public class RebasedUpperLeftComponent : ScreenComponent<WpfGroup>
    {
        public RebasedUpperLeftComponent()
            : base(By.AutomationId("VHdOp0Tn4UyfmV6U91ZCIw"))
        {
        }

        public bool CheckBoxExists
        {
            get { return Find<WpfCheckBox>(By.AutomationId("Ax9iHEo2gk-ayRFljKt2sA")).Exists; }
        }
    }
}