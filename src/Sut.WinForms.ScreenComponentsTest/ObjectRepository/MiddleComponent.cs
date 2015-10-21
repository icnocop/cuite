using CUITe.Controls.WinControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ScreenComponentsTest.ObjectRepository
{
    public class MiddleComponent : ScreenComponent
    {
        public DialogScreen NavigateToModalDialogScreen()
        {
            Find<WinButton>(By.Name("Open Modal Dialog")).Click();
            return NavigateTo<DialogScreen>();
        }

        public DialogScreen NavigateToNonModalDialogScreen()
        {
            Find<WinButton>(By.Name("Open Non-Modal Dialog")).Click();
            return NavigateTo<DialogScreen>();
        }
    }
}
