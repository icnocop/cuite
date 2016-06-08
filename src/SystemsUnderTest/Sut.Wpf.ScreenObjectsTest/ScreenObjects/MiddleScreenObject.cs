using CUITe.Controls.WpfControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.Wpf.ScreenObjectsTest.ScreenObjects
{
    public class MiddleScreenObject : ScreenObject
    {
        public DialogScreen NavigateToModalDialogScreen()
        {
            Find<WpfButton>(By.AutomationId("wimAM1xvJkqKO5jO9uUrSg")).Click();
            return NavigateTo<DialogScreen>("Dialog");
        }

        public DialogScreen NavigateToNonModalDialogScreen()
        {
            Find<WpfButton>(By.AutomationId("i_mSaEucbU-ohslSj7y9aA")).Click();
            return NavigateTo<DialogScreen>("Dialog");
        }

        public IdenticalButtonContentScreen NavigateToIdenticalButtonContentScreen()
        {
            Find<WpfButton>(By.Name("Identical Button Content")).Click();
            return NavigateTo<IdenticalButtonContentScreen>("Identical Button Content Dialog");
        }
    }
}