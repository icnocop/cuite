using CUITe.Controls.WpfControls;

namespace Sut.Wpf.ControlsTest.ScreenObjects
{
    public class MainScreen : WpfWindow
    {
        public MainScreen()
            : base("Name=System Under Test (WPF)")
        {
        }

        public WpfButton Button
        {
            get { return Find<WpfButton>("AutomationID=dy9cW2km1UuBP09fWHnKbw"); }
        }

        public WpfCalendar Calendar
        {
            get { return Find<WpfCalendar>("AutomationID=EgeommzT5kWRxblsOiVzQw"); }
        }

        public WpfCheckBox CheckBox
        {
            get { return Find<WpfCheckBox>("AutomationID=HmXXZ00CFU-T1FkzPQmjyQ"); }
        }

        public WpfComboBox ComboBox
        {
            get { return Find<WpfComboBox>("AutomationID=NGxFajDSKk-B-qcVRv2TaA"); }
        }

        public WpfCustom CustomControl
        {
            get { return Find<WpfCustom>("AutomationID=KGEvPCvvfk6pZdeMLHfm7w"); }
        }

        public WpfTable DataGrid
        {
            get { return Find<WpfTable>("AutomationID=D6p9vB7vZ0usMJfqrJSLIA"); }
        }

        public WpfDatePicker DatePicker
        {
            get { return Find<WpfDatePicker>("AutomationID=_xTenYVlIUanYa3k9E_jFA"); }
        }

        public WpfExpander Expander
        {
            get { return Find<WpfExpander>("AutomationID=RiELOT_TSE2kbTcomKC5fg"); }
        }

        public WpfPane Frame
        {
            get { return Find<WpfPane>("AutomationID=7nwuAp78G0WLkYBTz8OZFQ"); }
        }

        public WpfGroup GroupBox
        {
            get { return Find<WpfGroup>("AutomationID=o2bFF0rvWUCeBpEHvsinkQ"); }
        }

        public WpfHyperlink Hyperlink
        {
            get { return Find<WpfHyperlink>("AutomationID=hAIOIKzmYkSfl-J2MzyGTw"); }
        }

        public WpfImage Image
        {
            get { return Find<WpfImage>("AutomationID=zr9NDxeDvUujUjpHvXHVpA"); }
        }

        public WpfText Label
        {
            get { return Find<WpfText>("AutomationID=uHUfIlxst0q9y52sqsTZ0Q"); }
        }

        public WpfList ListBox
        {
            get { return Find<WpfList>("AutomationID=BcHUFLP0hkG4V6J55oDmYQ"); }
        }

        public WpfTable ListView
        {
            get { return Find<WpfTable>("AutomationID=mSGVZSH9uEeMMEVCBqPd5w"); }
        }

        public WpfMenu Menu
        {
            get { return Find<WpfMenu>("AutomationID=FVlubT4eKEi1arOesOkuTw"); }
        }

        public WpfEdit PasswordBox
        {
            get { return Find<WpfEdit>("AutomationID=v-eB3TBaOkSzT8pc2Pn4vQ"); }
        }

        public WpfProgressBar ProgressBar
        {
            get { return Find<WpfProgressBar>("AutomationID=yg3iMNLxZU2ajecAkDij3g"); }
        }

        public WpfRadioButton RadioButton
        {
            get { return Find<WpfRadioButton>("AutomationID=iuotwNwzykWAg90hsskgBw"); }
        }

        public WpfEdit RichTextBox
        {
            get { return Find<WpfEdit>("AutomationID=tVhBHnHl0UiuQ0siPpPzYg"); }
        }

        public WpfScrollBar ScrollBar
        {
            get { return Find<WpfScrollBar>("AutomationID=EaIQgF5jNk6XiSg6SO6d8A"); }
        }

        public WpfPane ScrollViewer
        {
            get { return Find<WpfPane>("AutomationID=DLFdnE5ogE26ZXPYTwiXjA"); }
        }

        public WpfSeparator Separator
        {
            get { return Find<WpfSeparator>("AutomationID=QtjLisTcxkmoC7Td8r4SRg"); }
        }

        public WpfSlider Slider
        {
            get { return Find<WpfSlider>("AutomationID=fHu0DLdks0Oo46Zf-mLd7g"); }
        }

        public WpfStatusBar StatusBar
        {
            get { return Find<WpfStatusBar>("AutomationID=is9FFBKLNkqy8YH80wCvOA"); }
        }

        public WpfTabList TabControl
        {
            get { return Find<WpfTabList>("AutomationID=n7WYM4yUsk-pwCKVXDalZQ"); }
        }

        public WpfText TextBlock
        {
            get { return Find<WpfText>("AutomationID=dCBRDmm9kEm2_u4Fdm9V4g"); }
        }

        public WpfEdit TextBox
        {
            get { return Find<WpfEdit>("AutomationID=fiJMHniwwE-AoTd66JyxBg"); }
        }

        public WpfToggleButton ToggleButton
        {
            get { return Find<WpfToggleButton>("AutomationID=eZq62SNMQ0S6wq0XRcFVxQ"); }
        }

        public WpfToolBar ToolBar
        {
            get { return Find<WpfToolBar>("AutomationID=AClh_S8BtEKS99-1gPOofQ"); }
        }

        public WpfText ToolTipTrigger
        {
            get { return Find<WpfText>("AutomationID=w9fB_ynzgEeIO2_9EJnkjw"); }
        }

        public WpfTree TreeView
        {
            get { return Find<WpfTree>("AutomationID=KDe9Dr8_kEuy9PZl5onvGQ"); }
        }
    }
}