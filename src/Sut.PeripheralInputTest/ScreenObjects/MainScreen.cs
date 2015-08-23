using CUITe.Controls.WpfControls;

namespace Sut.PeripheralInputTest.ScreenObjects
{
    public class MainScreen : WpfWindow
    {
        public MainScreen()
            : base("Name=Application Under Test (Peripheral Input)")
        {
        }

        public WpfText MouseClickText
        {
            get { return Get<WpfText>("AutomationID=i5BpTf7kjkyn51Hp-91V1Q"); }
        }

        public WpfEdit MouseClickResult
        {
            get { return Get<WpfEdit>("AutomationID=PpktgwLnNkqUl51Gfnc0jQ"); }
        }

        public WpfEdit KeyboardResult
        {
            get { return Get<WpfEdit>("AutomationID=U0xqM3rkzUmzBDmjTJa_aQ"); }
        }
    }
}