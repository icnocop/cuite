using CUITe.Controls.WinControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ScreenObjectsTest.ScreenObjects
{
    public class RebasedLowerLeftScreenObject : ScreenObject<WinGroup>
    {
        public RebasedLowerLeftScreenObject()
            : base(By.ControlName("groupBoxLowerLeft"))
        {
        }

        public bool RadioButtonExists
        {
            get { return Find<WinRadioButton>(By.ControlName("radioButtonLowerLeft")).Exists; }
        }
    }
}