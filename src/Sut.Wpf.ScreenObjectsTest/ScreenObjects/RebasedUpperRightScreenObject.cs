using CUITe.Controls.WpfControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.Wpf.ScreenObjectsTest.ScreenObjects
{
    public class RebasedUpperRightScreenObject : ScreenObject<WpfGroup>
    {
        public RebasedUpperRightScreenObject()
            : base(By.AutomationId("L9Z3HQOziUWAllix8yzsEg"))
        {
        }

        public bool CheckBoxExists
        {
            get { return Find<WpfCheckBox>(By.AutomationId("C_-kLEiiN0Odz20KncjQJQ")).Exists; }
        }
    }
}