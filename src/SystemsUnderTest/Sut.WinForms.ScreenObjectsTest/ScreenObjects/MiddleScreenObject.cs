using CUITe.Controls.WinControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ScreenObjectsTest.ScreenObjects
{
    public class MiddleScreenObject : ScreenObject
    {
        public DialogScreen NavigateToModalDialogScreen()
        {
            Find<WinButton>(By.Name("Open Modal Dialog")).Click();
            return NavigateTo<DialogScreen>("Dialog");
        }

        public DialogScreen NavigateToNonModalDialogScreen()
        {
            Find<WinButton>(By.Name("Open Non-Modal Dialog")).Click();
            return NavigateTo<DialogScreen>("Dialog");
        }

        public IdenticalButtonContentScreen NavigateToIdenticalButtonContentScreen()
        {
            Find<WinButton>(By.Name("Identical Button Content")).Click();
            return NavigateTo<IdenticalButtonContentScreen>("Identical Button Content Dialog");
        }
    }
}