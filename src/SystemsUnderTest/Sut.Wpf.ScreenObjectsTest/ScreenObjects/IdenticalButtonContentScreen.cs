using CUITe.Controls.WpfControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.Wpf.ScreenObjectsTest.ScreenObjects
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
            Find<WpfButton>(By.Name("Identical Button Content")).Click();
        }
    }
}