using CUITe.Controls.WpfControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.Wpf.ScreenComponentsTest.ObjectRepository
{
    public class MiddleComponent : ScreenComponent
    {
        public DialogScreen NavigateToModalDialogScreen()
        {
            Find<WpfButton>(By.AutomationId("wimAM1xvJkqKO5jO9uUrSg")).Click();
            return NavigateTo<DialogScreen>();
        }

        public DialogScreen NavigateToNonModalDialogScreen()
        {
            Find<WpfButton>(By.AutomationId("i_mSaEucbU-ohslSj7y9aA")).Click();
            return NavigateTo<DialogScreen>();
        }
    }
}