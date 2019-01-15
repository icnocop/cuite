using CUITe.Controls.WinControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ScreenObjectsTest.ScreenObjects
{
    public class RebasedLowerRightScreenObject : ScreenObject<WinWindow>
    {
        public RebasedLowerRightScreenObject()
            : base(By.ControlName("groupBoxLowerRight"))
        {
        }

        public bool RadioButtonExists
        {
            get { return Find<WinWindow>(By.ControlName("radioButtonLowerRight")).Find<WinRadioButton>().Exists; }
        }
    }
}