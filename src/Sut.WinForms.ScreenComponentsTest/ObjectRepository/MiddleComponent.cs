using CUITe.Controls.WinControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ScreenComponentsTest.ObjectRepository
{
    public class MiddleComponent : ScreenComponent
    {
        public DialogScreen NavigateToModalDialogScreen()
        {
            Find<WinButton>(By.ControlName("buttonOpenModalDialog")).Click();
            return NavigateTo<DialogScreen>();
        }

        public DialogScreen NavigateToNonModalDialogScreen()
        {
            Find<WinButton>(By.ControlName("buttonOpenNonModalDialog")).Click();
            return NavigateTo<DialogScreen>();
        }
    }
}
