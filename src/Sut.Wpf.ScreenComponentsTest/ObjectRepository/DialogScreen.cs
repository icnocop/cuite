using CUITe.Controls.WpfControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.Wpf.ScreenComponentsTest.ObjectRepository
{
    public class DialogScreen : Screen
    {
        public bool CloseButtonExists
        {
            get { return Find<WpfButton>(By.AutomationId("X_069FQuNE-ju0UKv24OUA")).Exists; }
        }
    }
}