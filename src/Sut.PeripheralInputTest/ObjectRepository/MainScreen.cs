using CUITe.Controls.WpfControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.PeripheralInputTest.ObjectRepository
{
    public class MainScreen : Screen
    {
        public WpfText MouseClickText
        {
            get { return Find<WpfText>(By.AutomationId("i5BpTf7kjkyn51Hp-91V1Q")); }
        }

        public WpfEdit MouseClickResult
        {
            get { return Find<WpfEdit>(By.AutomationId("PpktgwLnNkqUl51Gfnc0jQ")); }
        }

        public WpfEdit KeyboardResult
        {
            get { return Find<WpfEdit>(By.AutomationId("U0xqM3rkzUmzBDmjTJa_aQ")); }
        }
    }
}