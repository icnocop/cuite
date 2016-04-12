using CUITe.Controls.WpfControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.Wpf.ScreenObjectsTest.ScreenObjects
{
    public class RebasedUpperLeftScreenObject : ScreenObject<WpfGroup>
    {
        public RebasedUpperLeftScreenObject()
            : base(By.AutomationId("VHdOp0Tn4UyfmV6U91ZCIw"))
        {
        }

        public bool CheckBoxExists
        {
            get { return Find<WpfCheckBox>(By.AutomationId("Ax9iHEo2gk-ayRFljKt2sA")).Exists; }
        }
    }
}