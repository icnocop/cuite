using CUITe.Controls.WpfControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.Wpf.ScreenObjectsTest.ScreenObjects
{
    /// <summary>
    /// Middle Screen Object
    /// </summary>
    /// <seealso cref="CUITe.ScreenObjects.ScreenObject" />
    public class MiddleScreenObject : ScreenObject
    {
        /// <summary>
        /// Navigates to modal dialog screen.
        /// </summary>
        /// <returns>The dialog screen.</returns>
        public DialogScreen NavigateToModalDialogScreen()
        {
            Find<WpfButton>(By.AutomationId("wimAM1xvJkqKO5jO9uUrSg")).Click();
            return NavigateTo<DialogScreen>("Dialog");
        }

        /// <summary>
        /// Navigates to non modal dialog screen.
        /// </summary>
        /// <returns>The dialog screen.</returns>
        public DialogScreen NavigateToNonModalDialogScreen()
        {
            Find<WpfButton>(By.AutomationId("i_mSaEucbU-ohslSj7y9aA")).Click();
            return NavigateTo<DialogScreen>("Dialog");
        }

        /// <summary>
        /// Navigates to identical button content screen.
        /// </summary>
        /// <returns>The identical button content screen.</returns>
        public IdenticalButtonContentScreen NavigateToIdenticalButtonContentScreen()
        {
            Find<WpfButton>(By.Name("Identical Button Content")).Click();
            return NavigateTo<IdenticalButtonContentScreen>("Identical Button Content Dialog");
        }
    }
}