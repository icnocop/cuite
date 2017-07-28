using CUITe.Controls.WpfControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.PeripheralInputTest.ScreenObjects
{
    /// <summary>
    /// Main Screen
    /// </summary>
    /// <seealso cref="CUITe.ScreenObjects.Screen" />
    public class MainScreen : Screen
    {
        /// <summary>
        /// Gets the mouse click text.
        /// </summary>
        /// <value>
        /// The mouse click text.
        /// </value>
        public WpfText MouseClickText
        {
            get { return Find<WpfText>(By.AutomationId("i5BpTf7kjkyn51Hp-91V1Q")); }
        }

        /// <summary>
        /// Gets the mouse click result.
        /// </summary>
        /// <value>
        /// The mouse click result.
        /// </value>
        public WpfEdit MouseClickResult
        {
            get { return Find<WpfEdit>(By.AutomationId("PpktgwLnNkqUl51Gfnc0jQ")); }
        }

        /// <summary>
        /// Gets the keyboard result.
        /// </summary>
        /// <value>
        /// The keyboard result.
        /// </value>
        public WpfEdit KeyboardResult
        {
            get { return Find<WpfEdit>(By.AutomationId("U0xqM3rkzUmzBDmjTJa_aQ")); }
        }
    }
}