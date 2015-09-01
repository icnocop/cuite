using CUITe.Controls.WpfControls;

namespace Sut.PeripheralInputTest.ScreenObjects
{
    public class MainScreen : WpfWindow
    {
        public MainScreen()
            : base("Name=System Under Test (Peripheral Input)")
        {
        }

        public WpfText MouseClickText
        {
            get { return Find<WpfText>("AutomationID=i5BpTf7kjkyn51Hp-91V1Q"); }
        }

        public WpfEdit MouseClickResult
        {
            get { return Find<WpfEdit>("AutomationID=PpktgwLnNkqUl51Gfnc0jQ"); }
        }

        public WpfEdit KeyboardResult
        {
            get { return Find<WpfEdit>("AutomationID=U0xqM3rkzUmzBDmjTJa_aQ"); }
        }
    }
}