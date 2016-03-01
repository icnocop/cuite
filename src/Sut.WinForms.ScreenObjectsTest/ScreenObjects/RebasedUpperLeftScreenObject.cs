using CUITe.Controls.WinControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ScreenObjectsTest.ScreenObjects
{
    public class RebasedUpperLeftScreenObject : ScreenObject<WinGroup>
    {
        public RebasedUpperLeftScreenObject()
            : base(By.ControlName("groupBoxUpperLeft"))
        {
        }

        public bool CheckBoxExists
        {
            get { return Find<WinCheckBox>(By.ControlName("checkBoxUpperLeft")).Exists; }
        }
    }
}