using CUITe.Controls.WinControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace CUITe.IntegrationTests.ObjectRecorder.Screens
{
    public class Notepad : Screen
    {
        private WinWindow MainWindow
        {
            get { return Find<WinWindow>(By.ControlId("15")); }
        }

        public WinEdit TextBox
        {
            get { return MainWindow.Find<WinEdit>(); }
        }
    }
}
