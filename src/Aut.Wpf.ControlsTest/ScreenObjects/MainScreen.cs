using CUITe.Controls.WpfControls;

namespace Aut.Wpf.ControlsTest.ScreenObjects
{
    public class MainScreen : WpfWindow
    {
        public MainScreen()
            : base("Name=Application Under Test (WPF)")
        {
        }

        public WpfButton Button
        {
            get { return Get<WpfButton>("AutomationID=dy9cW2km1UuBP09fWHnKbw"); }
        }

        public WpfCalendar Calendar
        {
            get { return Get<WpfCalendar>("AutomationID=EgeommzT5kWRxblsOiVzQw"); }
        }

        public WpfCheckBox CheckBox
        {
            get { return Get<WpfCheckBox>("AutomationID=HmXXZ00CFU-T1FkzPQmjyQ"); }
        }

        public WpfComboBox ComboBox
        {
            get { return Get<WpfComboBox>("AutomationID=NGxFajDSKk-B-qcVRv2TaA"); }
        }

        public WpfCustom CustomControl
        {
            get { return Get<WpfCustom>("AutomationID=KGEvPCvvfk6pZdeMLHfm7w"); }
        }

        public WpfTable DataGrid
        {
            get { return Get<WpfTable>("AutomationID=D6p9vB7vZ0usMJfqrJSLIA"); }
        }

        public WpfDatePicker DatePicker
        {
            get { return Get<WpfDatePicker>("AutomationID=_xTenYVlIUanYa3k9E_jFA"); }
        }

        public WpfExpander Expander
        {
            get { return Get<WpfExpander>("AutomationID=RiELOT_TSE2kbTcomKC5fg"); }
        }

        public WpfPane Frame
        {
            get { return Get<WpfPane>("AutomationID=7nwuAp78G0WLkYBTz8OZFQ"); }
        }

        public WpfGroup GroupBox
        {
            get { return Get<WpfGroup>("AutomationID=o2bFF0rvWUCeBpEHvsinkQ"); }
        }

        public WpfHyperlink Hyperlink
        {
            get { return Get<WpfHyperlink>("AutomationID=hAIOIKzmYkSfl-J2MzyGTw"); }
        }

        public WpfImage Image
        {
            get { return Get<WpfImage>("AutomationID=zr9NDxeDvUujUjpHvXHVpA"); }
        }

        public WpfText Label
        {
            get { return Get<WpfText>("AutomationID=uHUfIlxst0q9y52sqsTZ0Q"); }
        }

        public WpfList ListBox
        {
            get { return Get<WpfList>("AutomationID=BcHUFLP0hkG4V6J55oDmYQ"); }
        }

        public WpfTable ListView
        {
            get { return Get<WpfTable>("AutomationID=mSGVZSH9uEeMMEVCBqPd5w"); }
        }

        public WpfMenu Menu
        {
            get { return Get<WpfMenu>("AutomationID=FVlubT4eKEi1arOesOkuTw"); }
        }

        public WpfEdit PasswordBox
        {
            get { return Get<WpfEdit>("AutomationID=v-eB3TBaOkSzT8pc2Pn4vQ"); }
        }

        public WpfProgressBar ProgressBar
        {
            get { return Get<WpfProgressBar>("AutomationID=yg3iMNLxZU2ajecAkDij3g"); }
        }

        public WpfRadioButton RadioButton
        {
            get { return Get<WpfRadioButton>("AutomationID=iuotwNwzykWAg90hsskgBw"); }
        }

        public WpfEdit RichTextBox
        {
            get { return Get<WpfEdit>("AutomationID=tVhBHnHl0UiuQ0siPpPzYg"); }
        }

        public WpfScrollBar ScrollBar
        {
            get { return Get<WpfScrollBar>("AutomationID=EaIQgF5jNk6XiSg6SO6d8A"); }
        }

        public WpfPane ScrollViewer
        {
            get { return Get<WpfPane>("AutomationID=DLFdnE5ogE26ZXPYTwiXjA"); }
        }

        public WpfSeparator Separator
        {
            get { return Get<WpfSeparator>("AutomationID=QtjLisTcxkmoC7Td8r4SRg"); }
        }

        public WpfSlider Slider
        {
            get { return Get<WpfSlider>("AutomationID=fHu0DLdks0Oo46Zf-mLd7g"); }
        }

        public WpfStatusBar StatusBar
        {
            get { return Get<WpfStatusBar>("AutomationID=is9FFBKLNkqy8YH80wCvOA"); }
        }

        public WpfTabList TabControl
        {
            get { return Get<WpfTabList>("AutomationID=n7WYM4yUsk-pwCKVXDalZQ"); }
        }

        public WpfText TextBlock
        {
            get { return Get<WpfText>("AutomationID=dCBRDmm9kEm2_u4Fdm9V4g"); }
        }

        public WpfEdit TextBox
        {
            get { return Get<WpfEdit>("AutomationID=fiJMHniwwE-AoTd66JyxBg"); }
        }

        public WpfToggleButton ToggleButton
        {
            get { return Get<WpfToggleButton>("AutomationID=eZq62SNMQ0S6wq0XRcFVxQ"); }
        }

        public WpfToolBar ToolBar
        {
            get { return Get<WpfToolBar>("AutomationID=AClh_S8BtEKS99-1gPOofQ"); }
        }

        public WpfText ToolTipTrigger
        {
            get { return Get<WpfText>("AutomationID=w9fB_ynzgEeIO2_9EJnkjw"); }
        }

        public WpfTree TreeView
        {
            get { return Get<WpfTree>("AutomationID=KDe9Dr8_kEuy9PZl5onvGQ"); }
        }
    }
}