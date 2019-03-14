using CUITe.Controls.WinControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace CUITe.IntegrationTests.ObjectRecorder.Screens
{
    /// <summary>
    /// Notepad
    /// </summary>
    /// <seealso cref="CUITe.ScreenObjects.Screen" />
    public class Notepad : Screen
    {
        private WinWindow MainWindow
        {
            get { return Find<WinWindow>(By.ControlId("15")); }
        }

        /// <summary>
        /// Gets the text box.
        /// </summary>
        /// <value>
        /// The text box.
        /// </value>
        public WinEdit TextBox
        {
            get { return MainWindow.Find<WinEdit>(); }
        }
    }
}
