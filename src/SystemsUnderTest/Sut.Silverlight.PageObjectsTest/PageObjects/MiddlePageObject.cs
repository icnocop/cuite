using CUITe.Controls.SilverlightControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.Silverlight.PageObjectsTest.PageObjects
{
    public class MiddlePageObject : PageObject
    {
        public DialogPage NavigateToDialogPage()
        {
            Find<SilverlightButton>(By.AutomationId("MjovOFqiTEaV1jfhwkLrhA")).Click();
            return NavigateTo<DialogPage>();
        }
    }
}