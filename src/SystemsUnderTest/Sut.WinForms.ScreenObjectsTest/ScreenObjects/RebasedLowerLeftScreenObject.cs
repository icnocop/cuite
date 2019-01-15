using CUITe.Controls.WinControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ScreenObjectsTest.ScreenObjects
{
    public class RebasedLowerLeftScreenObject : ScreenObject<WinWindow>
    {
        public RebasedLowerLeftScreenObject()
            : base(By.ControlName("groupBoxLowerLeft"))
        {
        }

        public bool RadioButtonExists
        {
            get { return Find<WinWindow>(By.ControlName("radioButtonLowerLeft")).Find<WinRadioButton>().Exists; }
        }
    }
}