using CUITe.Controls.WinControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ScreenObjectsTest.ScreenObjects
{
    public class LowerRightScreenObject : ScreenObject
    {
        public bool RadioButtonExists
        {
            get { return Find<WinRadioButton>(By.ControlName("radioButtonLowerRight")).Exists; }
        }
    }
}