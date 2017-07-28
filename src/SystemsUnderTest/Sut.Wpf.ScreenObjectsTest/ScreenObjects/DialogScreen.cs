using CUITe.Controls.WpfControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.Wpf.ScreenObjectsTest.ScreenObjects
{
    /// <summary>
    /// Dialog Screen
    /// </summary>
    /// <seealso cref="CUITe.ScreenObjects.Screen" />
    public class DialogScreen : Screen
    {
        /// <summary>
        /// Gets the close button.
        /// </summary>
        /// <value>
        /// The close button.
        /// </value>
        public WpfButton CloseButton
        {
            get { return Find<WpfButton>(By.AutomationId("X_069FQuNE-ju0UKv24OUA")); }
        }
    }
}