using CUITe.Controls.WpfControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.Wpf.ControlsTest.ObjectRepository
{
    public class MainScreen : Screen
    {
        public WpfButton Button
        {
            get { return Find<WpfButton>(By.AutomationId("dy9cW2km1UuBP09fWHnKbw")); }
        }

        public WpfCalendar Calendar
        {
            get { return Find<WpfCalendar>(By.AutomationId("EgeommzT5kWRxblsOiVzQw")); }
        }

        public WpfCheckBox CheckBox
        {
            get { return Find<WpfCheckBox>(By.AutomationId("HmXXZ00CFU-T1FkzPQmjyQ")); }
        }

        public WpfComboBox ComboBox
        {
            get { return Find<WpfComboBox>(By.AutomationId("NGxFajDSKk-B-qcVRv2TaA")); }
        }

        public WpfCustom CustomControl
        {
            get { return Find<WpfCustom>(By.AutomationId("KGEvPCvvfk6pZdeMLHfm7w")); }
        }

        public WpfTable DataGrid
        {
            get { return Find<WpfTable>(By.AutomationId("D6p9vB7vZ0usMJfqrJSLIA")); }
        }

        public WpfDatePicker DatePicker
        {
            get { return Find<WpfDatePicker>(By.AutomationId("_xTenYVlIUanYa3k9E_jFA")); }
        }

        public WpfExpander Expander
        {
            get { return Find<WpfExpander>(By.AutomationId("RiELOT_TSE2kbTcomKC5fg")); }
        }

        public WpfPane Frame
        {
            get { return Find<WpfPane>(By.AutomationId("7nwuAp78G0WLkYBTz8OZFQ")); }
        }

        public WpfGroup GroupBox
        {
            get { return Find<WpfGroup>(By.AutomationId("o2bFF0rvWUCeBpEHvsinkQ")); }
        }

        public WpfHyperlink Hyperlink
        {
            get { return Find<WpfHyperlink>(By.AutomationId("hAIOIKzmYkSfl-J2MzyGTw")); }
        }

        public WpfImage Image
        {
            get { return Find<WpfImage>(By.AutomationId("zr9NDxeDvUujUjpHvXHVpA")); }
        }

        public WpfText Label
        {
            get { return Find<WpfText>(By.AutomationId("uHUfIlxst0q9y52sqsTZ0Q")); }
        }

        public WpfList ListBox
        {
            get { return Find<WpfList>(By.AutomationId("BcHUFLP0hkG4V6J55oDmYQ")); }
        }

        public WpfTable ListView
        {
            get { return Find<WpfTable>(By.AutomationId("mSGVZSH9uEeMMEVCBqPd5w")); }
        }

        public WpfMenu Menu
        {
            get { return Find<WpfMenu>(By.AutomationId("FVlubT4eKEi1arOesOkuTw")); }
        }

        public WpfEdit PasswordBox
        {
            get { return Find<WpfEdit>(By.AutomationId("v-eB3TBaOkSzT8pc2Pn4vQ")); }
        }

        public WpfProgressBar ProgressBar
        {
            get { return Find<WpfProgressBar>(By.AutomationId("yg3iMNLxZU2ajecAkDij3g")); }
        }

        public WpfRadioButton RadioButton
        {
            get { return Find<WpfRadioButton>(By.AutomationId("iuotwNwzykWAg90hsskgBw")); }
        }

        public WpfEdit RichTextBox
        {
            get { return Find<WpfEdit>(By.AutomationId("tVhBHnHl0UiuQ0siPpPzYg")); }
        }

        public WpfScrollBar ScrollBar
        {
            get { return Find<WpfScrollBar>(By.AutomationId("EaIQgF5jNk6XiSg6SO6d8A")); }
        }

        public WpfPane ScrollViewer
        {
            get { return Find<WpfPane>(By.AutomationId("DLFdnE5ogE26ZXPYTwiXjA")); }
        }

        public WpfSeparator Separator
        {
            get { return Find<WpfSeparator>(By.AutomationId("QtjLisTcxkmoC7Td8r4SRg")); }
        }

        public WpfSlider Slider
        {
            get { return Find<WpfSlider>(By.AutomationId("fHu0DLdks0Oo46Zf-mLd7g")); }
        }

        public WpfStatusBar StatusBar
        {
            get { return Find<WpfStatusBar>(By.AutomationId("is9FFBKLNkqy8YH80wCvOA")); }
        }

        public WpfTabList TabControl
        {
            get { return Find<WpfTabList>(By.AutomationId("n7WYM4yUsk-pwCKVXDalZQ")); }
        }

        public WpfText TextBlock
        {
            get { return Find<WpfText>(By.AutomationId("dCBRDmm9kEm2_u4Fdm9V4g")); }
        }

        public WpfEdit TextBox
        {
            get { return Find<WpfEdit>(By.AutomationId("fiJMHniwwE-AoTd66JyxBg")); }
        }

        public WpfToggleButton ToggleButton
        {
            get { return Find<WpfToggleButton>(By.AutomationId("eZq62SNMQ0S6wq0XRcFVxQ")); }
        }

        public WpfToolBar ToolBar
        {
            get { return Find<WpfToolBar>(By.AutomationId("AClh_S8BtEKS99-1gPOofQ")); }
        }

        public WpfText ToolTipTrigger
        {
            get { return Find<WpfText>(By.AutomationId("w9fB_ynzgEeIO2_9EJnkjw")); }
        }

        public WpfTree TreeView
        {
            get { return Find<WpfTree>(By.AutomationId("KDe9Dr8_kEuy9PZl5onvGQ")); }
        }
    }
}