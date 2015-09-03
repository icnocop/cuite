using CUITe.Controls.WpfControls;
using CUITe.SearchConfigurations;

namespace Sut.PeripheralInputTest.ScreenObjects
{
    public class MainScreen : WpfWindow
    {
        public MainScreen()
            : base(By.SearchProperties("Name=System Under Test (Peripheral Input)"))
        {
        }

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