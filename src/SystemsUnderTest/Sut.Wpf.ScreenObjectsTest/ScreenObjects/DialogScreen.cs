using CUITe.Controls.WpfControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.Wpf.ScreenObjectsTest.ScreenObjects
{
    public class DialogScreen : Screen
    {
        public bool CloseButtonExists
        {
            get { return Find<WpfButton>(By.AutomationId("X_069FQuNE-ju0UKv24OUA")).Exists; }
        }
    }
}