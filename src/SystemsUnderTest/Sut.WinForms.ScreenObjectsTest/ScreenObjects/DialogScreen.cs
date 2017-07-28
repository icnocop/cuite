using CUITe.Controls.WinControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ScreenObjectsTest.ScreenObjects
{
    /// <summary>
    /// Dialog Screen
    /// </summary>
    /// <seealso cref="CUITe.ScreenObjects.Screen" />
    public class DialogScreen : Screen
    {
        /// <summary>
        /// Gets a value indicating whether the close button exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the close button exists; otherwise, <c>false</c>.
        /// </value>
        public bool CloseButtonExists
        {
            get { return Find<WinWindow>(By.ControlName("buttonClose")).Find<WinButton>().Exists; }
        }
    }
}