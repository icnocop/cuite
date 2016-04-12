using CUITe.Controls.WinControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ScreenObjectsTest.ScreenObjects
{
    public class RebasedUpperRightScreenObject : ScreenObject<WinGroup>
    {
        public RebasedUpperRightScreenObject()
            : base(By.ControlName("groupBoxUpperRight"))
        {
        }

        public bool CheckBoxExists
        {
            get { return Find<WinCheckBox>(By.ControlName("checkBoxUpperRight")).Exists; }
        }
    }
}