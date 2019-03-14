using CUITe.Controls.SilverlightControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.Silverlight.PageObjectsTest.PageObjects
{
    /// <summary>
    /// Middle Page Object
    /// </summary>
    /// <seealso cref="CUITe.PageObjects.PageObject" />
    public class MiddlePageObject : PageObject
    {
        /// <summary>
        /// Navigates to dialog page.
        /// </summary>
        /// <returns>The dialog page</returns>
        public DialogPage NavigateToDialogPage()
        {
            Find<SilverlightButton>(By.AutomationId("MjovOFqiTEaV1jfhwkLrhA")).Click();
            return NavigateTo<DialogPage>();
        }
    }
}