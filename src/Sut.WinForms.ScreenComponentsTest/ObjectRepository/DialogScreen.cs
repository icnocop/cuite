using CUITe.Controls.WinControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ScreenComponentsTest.ObjectRepository
{
    public class DialogScreen : Screen
    {
        public bool CloseButtonExists
        {
            get { return Find<WinButton>(By.Name("Close")).Exists; }
        }
    }
}