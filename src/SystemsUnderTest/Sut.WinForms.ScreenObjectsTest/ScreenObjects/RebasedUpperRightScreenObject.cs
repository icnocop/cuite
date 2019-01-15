using CUITe.Controls.WinControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ScreenObjectsTest.ScreenObjects
{
    public class RebasedUpperRightScreenObject : ScreenObject<WinWindow>
    {
        public RebasedUpperRightScreenObject()
            : base(By.ControlName("groupBoxUpperRight"))
        {
        }

        public bool CheckBoxExists
        {
            get { return Find<WinWindow>(By.ControlName("checkBoxUpperRight")).Find<WinCheckBox>().Exists; }
        }
    }
}