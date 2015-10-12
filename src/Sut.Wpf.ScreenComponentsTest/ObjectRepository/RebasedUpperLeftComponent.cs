using CUITe.Controls.WpfControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.Wpf.ScreenComponentsTest.ObjectRepository
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