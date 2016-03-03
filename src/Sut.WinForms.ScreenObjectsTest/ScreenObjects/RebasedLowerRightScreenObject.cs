using CUITe.Controls.WinControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ScreenObjectsTest.ScreenObjects
{
    public class RebasedLowerRightScreenObject : ScreenObject<WinGroup>
    {
        public RebasedLowerRightScreenObject()
            : base(By.ControlName("groupBoxLowerRight"))
        {
        }

        public bool RadioButtonExists
        {
            get { return Find<WinRadioButton>(By.ControlName("radioButtonLowerRight")).Exists; }
        }
    }
}