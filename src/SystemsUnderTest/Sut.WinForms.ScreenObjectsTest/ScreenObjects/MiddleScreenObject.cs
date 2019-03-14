using CUITe.Controls.WinControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ScreenObjectsTest.ScreenObjects
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
            Find<WinButton>(By.Name("Open Modal Dialog")).Click();
            return NavigateTo<DialogScreen>("Dialog");
        }

        /// <summary>
        /// Navigates to non modal dialog screen.
        /// </summary>
        /// <returns>The dialog screen.</returns>
        public DialogScreen NavigateToNonModalDialogScreen()
        {
            Find<WinButton>(By.Name("Open Non-Modal Dialog")).Click();
            return NavigateTo<DialogScreen>("Dialog");
        }

        /// <summary>
        /// Navigates to identical button content screen.
        /// </summary>
        /// <returns>The indentical button content screen.</returns>
        public IdenticalButtonContentScreen NavigateToIdenticalButtonContentScreen()
        {
            Find<WinButton>(By.Name("Identical Button Content")).Click();
            return NavigateTo<IdenticalButtonContentScreen>("Identical Button Content Dialog");
        }
    }
}