using CUITe.Controls.WinControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ScreenObjectsTest.ScreenObjects
{
    public class DialogScreen : Screen
    {
        public bool CloseButtonExists
        {
            get { return Find<WinWindow>(By.ControlName("buttonClose")).Find<WinButton>().Exists; }
        }
    }
}