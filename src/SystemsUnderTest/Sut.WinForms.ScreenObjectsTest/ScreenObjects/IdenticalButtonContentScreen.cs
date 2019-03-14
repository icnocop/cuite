using CUITe.Controls.WinControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ScreenObjectsTest.ScreenObjects
{
    /// <summary>
    /// Identical Button Content Screen
    /// </summary>
    /// <seealso cref="CUITe.ScreenObjects.Screen" />
    public class IdenticalButtonContentScreen : Screen
    {
        /// <summary>
        /// Clicks the identical button.
        /// </summary>
        public void ClickIdenticalButton()
        {
            Find<WinButton>(By.Name("Identical Button Content")).Click();
        }
    }
}