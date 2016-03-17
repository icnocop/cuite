using CUITe.Controls.WinControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ScreenObjectsTest.ScreenObjects
{
    public class LowerLeftScreenObject : ScreenObject
    {
        public bool RadioButtonExists
        {
            get { return Find<WinRadioButton>(By.ControlName("radioButtonLowerLeft")).Exists; }
        }
    }
}