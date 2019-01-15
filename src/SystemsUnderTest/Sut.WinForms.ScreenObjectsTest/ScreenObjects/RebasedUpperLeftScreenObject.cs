using CUITe.Controls.WinControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ScreenObjectsTest.ScreenObjects
{
    public class RebasedUpperLeftScreenObject : ScreenObject<WinWindow>
    {
        public RebasedUpperLeftScreenObject()
            : base(By.ControlName("groupBoxUpperLeft"))
        {
        }

        public bool CheckBoxExists
        {
            get { return Find<WinWindow>(By.ControlName("checkBoxUpperLeft")).Find<WinCheckBox>().Exists; }
        }
    }
}