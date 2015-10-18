using CUITe.Controls.SilverlightControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.Silverlight.PageComponentsTest.ObjectRepository
{
    public class MiddleComponent : PageComponent
    {
        public DialogPage NavigateToNonModalDialogPage()
        {
            Find<SilverlightButton>(By.AutomationId("MjovOFqiTEaV1jfhwkLrhA")).Click();
            return NavigateTo<DialogPage>();
        }
    }
}