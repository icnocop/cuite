using CUITe.Controls.WpfControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.Wpf.ControlsTest.ObjectRepository
{
    public class MainScreen : Screen
    {
        public bool ButtonExists
        {
            get { return Find<WpfButton>(By.AutomationId("dy9cW2km1UuBP09fWHnKbw")).Exists; }
        }

        public bool CalendarExists
        {
            get { return Find<WpfCalendar>(By.AutomationId("EgeommzT5kWRxblsOiVzQw")).Exists; }
        }

        public bool CheckBoxExists
        {
            get { return Find<WpfCheckBox>(By.AutomationId("HmXXZ00CFU-T1FkzPQmjyQ")).Exists; }
        }

        public bool ComboBoxExists
        {
            get { return Find<WpfComboBox>(By.AutomationId("NGxFajDSKk-B-qcVRv2TaA")).Exists; }
        }

        public bool CustomControlExists
        {
            get { return Find<WpfCustom>(By.AutomationId("KGEvPCvvfk6pZdeMLHfm7w")).Exists; }
        }

        public bool DataGridExists
        {
            get { return Find<WpfTable>(By.AutomationId("D6p9vB7vZ0usMJfqrJSLIA")).Exists; }
        }

        public bool DatePickerExists
        {
            get { return Find<WpfDatePicker>(By.AutomationId("_xTenYVlIUanYa3k9E_jFA")).Exists; }
        }

        public bool ExpanderExists
        {
            get { return Find<WpfExpander>(By.AutomationId("RiELOT_TSE2kbTcomKC5fg")).Exists; }
        }

        public bool FrameExists
        {
            get { return Find<WpfPane>(By.AutomationId("7nwuAp78G0WLkYBTz8OZFQ")).Exists; }
        }

        public bool GroupBoxExists
        {
            get { return Find<WpfGroup>(By.AutomationId("o2bFF0rvWUCeBpEHvsinkQ")).Exists; }
        }

        public bool HyperlinkExists
        {
            get { return Find<WpfHyperlink>(By.AutomationId("hAIOIKzmYkSfl-J2MzyGTw")).Exists; }
        }

        public bool ImageExists
        {
            get { return Find<WpfImage>(By.AutomationId("zr9NDxeDvUujUjpHvXHVpA")).Exists; }
        }

        public bool LabelExists
        {
            get { return Find<WpfText>(By.AutomationId("uHUfIlxst0q9y52sqsTZ0Q")).Exists; }
        }

        public bool ListBoxExists
        {
            get { return Find<WpfList>(By.AutomationId("BcHUFLP0hkG4V6J55oDmYQ")).Exists; }
        }

        public bool ListViewExists
        {
            get { return Find<WpfTable>(By.AutomationId("mSGVZSH9uEeMMEVCBqPd5w")).Exists; }
        }

        public bool MenuExists
        {
            get { return Find<WpfMenu>(By.AutomationId("FVlubT4eKEi1arOesOkuTw")).Exists; }
        }

        public bool PasswordBoxExists
        {
            get { return Find<WpfEdit>(By.AutomationId("v-eB3TBaOkSzT8pc2Pn4vQ")).Exists; }
        }

        public bool ProgressBarExists
        {
            get { return Find<WpfProgressBar>(By.AutomationId("yg3iMNLxZU2ajecAkDij3g")).Exists; }
        }

        public bool RadioButtonExists
        {
            get { return Find<WpfRadioButton>(By.AutomationId("iuotwNwzykWAg90hsskgBw")).Exists; }
        }

        public bool RichTextBoxExists
        {
            get { return Find<WpfEdit>(By.AutomationId("tVhBHnHl0UiuQ0siPpPzYg")).Exists; }
        }

        public bool ScrollBarExists
        {
            get { return Find<WpfScrollBar>(By.AutomationId("EaIQgF5jNk6XiSg6SO6d8A")).Exists; }
        }

        public bool ScrollViewerExists
        {
            get { return Find<WpfPane>(By.AutomationId("DLFdnE5ogE26ZXPYTwiXjA")).Exists; }
        }

        public bool SeparatorExists
        {
            get { return Find<WpfSeparator>(By.AutomationId("QtjLisTcxkmoC7Td8r4SRg")).Exists; }
        }

        public bool SliderExists
        {
            get { return Find<WpfSlider>(By.AutomationId("fHu0DLdks0Oo46Zf-mLd7g")).Exists; }
        }

        public bool StatusBarExists
        {
            get { return Find<WpfStatusBar>(By.AutomationId("is9FFBKLNkqy8YH80wCvOA")).Exists; }
        }

        public bool TabControlExists
        {
            get { return Find<WpfTabList>(By.AutomationId("n7WYM4yUsk-pwCKVXDalZQ")).Exists; }
        }

        public bool TextBlockExists
        {
            get { return Find<WpfText>(By.AutomationId("dCBRDmm9kEm2_u4Fdm9V4g")).Exists; }
        }

        public bool TextBoxExists
        {
            get { return Find<WpfEdit>(By.AutomationId("fiJMHniwwE-AoTd66JyxBg")).Exists; }
        }

        public bool ToggleButtonExists
        {
            get { return Find<WpfToggleButton>(By.AutomationId("eZq62SNMQ0S6wq0XRcFVxQ")).Exists; }
        }

        public bool ToolBarExists
        {
            get { return Find<WpfToolBar>(By.AutomationId("AClh_S8BtEKS99-1gPOofQ")).Exists; }
        }

        public bool TreeViewExists
        {
            get { return Find<WpfTree>(By.AutomationId("KDe9Dr8_kEuy9PZl5onvGQ")).Exists; }
        }
    }
}