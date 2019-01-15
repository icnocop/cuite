using CUITe.Controls.WinControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ScreenObjectsTest.ScreenObjects
{
    public class LowerRightScreenObject : ScreenObject
    {
        public bool RadioButtonExists
        {
            get { return this.Window.Find<WinRadioButton>().Exists; }
        }

        private WinWindow Window
        {
            get
            {
                return this.Find<WinWindow>(By.ControlName("radioButtonLowerRight"));
            }
        }
    }
}