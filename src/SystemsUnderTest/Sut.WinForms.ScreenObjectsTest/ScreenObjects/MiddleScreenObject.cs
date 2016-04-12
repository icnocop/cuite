using CUITe.Controls.WinControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ScreenObjectsTest.ScreenObjects
{
    public class MiddleScreenObject : ScreenObject
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
