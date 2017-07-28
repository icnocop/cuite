using CUITe.Controls.WpfControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.Wpf.ControlsTest.ScreenObjects
{
    /// <summary>
    /// Main Screen
    /// </summary>
    /// <seealso cref="CUITe.ScreenObjects.Screen" />
    public class MainScreen : Screen
    {
        /// <summary>
        /// Gets a value indicating whether the button exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the button exists; otherwise, <c>false</c>.
        /// </value>
        public bool ButtonExists
        {
            get { return Find<WpfButton>(By.AutomationId("dy9cW2km1UuBP09fWHnKbw")).Exists; }
        }

        /// <summary>
        /// Gets a value indicating whether the calendar exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the calendar exists; otherwise, <c>false</c>.
        /// </value>
        public bool CalendarExists
        {
            get { return Find<WpfCalendar>(By.AutomationId("EgeommzT5kWRxblsOiVzQw")).Exists; }
        }

        /// <summary>
        /// Gets a value indicating whether the check box exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the check box exists; otherwise, <c>false</c>.
        /// </value>
        public bool CheckBoxExists
        {
            get { return Find<WpfCheckBox>(By.AutomationId("HmXXZ00CFU-T1FkzPQmjyQ")).Exists; }
        }

        /// <summary>
        /// Gets a value indicating whether the combo box exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the combo box exists; otherwise, <c>false</c>.
        /// </value>
        public bool ComboBoxExists
        {
            get { return Find<WpfComboBox>(By.AutomationId("NGxFajDSKk-B-qcVRv2TaA")).Exists; }
        }

        /// <summary>
        /// Gets a value indicating whether the custom control exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the custom control exists; otherwise, <c>false</c>.
        /// </value>
        public bool CustomControlExists
        {
            get { return Find<WpfCustom>(By.AutomationId("KGEvPCvvfk6pZdeMLHfm7w")).Exists; }
        }

        /// <summary>
        /// Gets a value indicating whether the data grid exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the data grid exists; otherwise, <c>false</c>.
        /// </value>
        public bool DataGridExists
        {
            get { return Find<WpfTable>(By.AutomationId("D6p9vB7vZ0usMJfqrJSLIA")).Exists; }
        }

        /// <summary>
        /// Gets a value indicating whether the date picker exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the date picker exists; otherwise, <c>false</c>.
        /// </value>
        public bool DatePickerExists
        {
            get { return Find<WpfDatePicker>(By.AutomationId("_xTenYVlIUanYa3k9E_jFA")).Exists; }
        }

        /// <summary>
        /// Gets a value indicating whether the expander exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the expander exists; otherwise, <c>false</c>.
        /// </value>
        public bool ExpanderExists
        {
            get { return Find<WpfExpander>(By.AutomationId("RiELOT_TSE2kbTcomKC5fg")).Exists; }
        }

        /// <summary>
        /// Gets a value indicating whether the frame exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the frame exists; otherwise, <c>false</c>.
        /// </value>
        public bool FrameExists
        {
            get { return Find<WpfPane>(By.AutomationId("7nwuAp78G0WLkYBTz8OZFQ")).Exists; }
        }

        /// <summary>
        /// Gets a value indicating whether the group box exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the group box exists; otherwise, <c>false</c>.
        /// </value>
        public bool GroupBoxExists
        {
            get { return Find<WpfGroup>(By.AutomationId("o2bFF0rvWUCeBpEHvsinkQ")).Exists; }
        }

        /// <summary>
        /// Gets a value indicating whether the hyperlink exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the hyperlink exists; otherwise, <c>false</c>.
        /// </value>
        public bool HyperlinkExists
        {
            get { return Find<WpfHyperlink>(By.AutomationId("hAIOIKzmYkSfl-J2MzyGTw")).Exists; }
        }

        /// <summary>
        /// Gets a value indicating whether the image exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the image exists; otherwise, <c>false</c>.
        /// </value>
        public bool ImageExists
        {
            get { return Find<WpfImage>(By.AutomationId("zr9NDxeDvUujUjpHvXHVpA")).Exists; }
        }

        /// <summary>
        /// Gets a value indicating whether the label exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the label exists; otherwise, <c>false</c>.
        /// </value>
        public bool LabelExists
        {
            get { return Find<WpfText>(By.AutomationId("uHUfIlxst0q9y52sqsTZ0Q")).Exists; }
        }

        /// <summary>
        /// Gets a value indicating whether the list box exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the list box exists; otherwise, <c>false</c>.
        /// </value>
        public bool ListBoxExists
        {
            get { return Find<WpfList>(By.AutomationId("BcHUFLP0hkG4V6J55oDmYQ")).Exists; }
        }

        /// <summary>
        /// Gets a value indicating whether list view exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the list view exists; otherwise, <c>false</c>.
        /// </value>
        public bool ListViewExists
        {
            get { return Find<WpfTable>(By.AutomationId("mSGVZSH9uEeMMEVCBqPd5w")).Exists; }
        }

        /// <summary>
        /// Gets a value indicating whether the menu exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the menu exists; otherwise, <c>false</c>.
        /// </value>
        public bool MenuExists
        {
            get { return Find<WpfMenu>(By.AutomationId("FVlubT4eKEi1arOesOkuTw")).Exists; }
        }

        /// <summary>
        /// Gets a value indicating whether the password box exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the password box exists; otherwise, <c>false</c>.
        /// </value>
        public bool PasswordBoxExists
        {
            get { return Find<WpfEdit>(By.AutomationId("v-eB3TBaOkSzT8pc2Pn4vQ")).Exists; }
        }

        /// <summary>
        /// Gets a value indicating whether the progress bar exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the progress bar exists; otherwise, <c>false</c>.
        /// </value>
        public bool ProgressBarExists
        {
            get { return Find<WpfProgressBar>(By.AutomationId("yg3iMNLxZU2ajecAkDij3g")).Exists; }
        }

        /// <summary>
        /// Gets a value indicating whether the radio button exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the radio button exists; otherwise, <c>false</c>.
        /// </value>
        public bool RadioButtonExists
        {
            get { return Find<WpfRadioButton>(By.AutomationId("iuotwNwzykWAg90hsskgBw")).Exists; }
        }

        /// <summary>
        /// Gets a value indicating whether the rich text box exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the rich text box exists; otherwise, <c>false</c>.
        /// </value>
        public bool RichTextBoxExists
        {
            get { return Find<WpfEdit>(By.AutomationId("tVhBHnHl0UiuQ0siPpPzYg")).Exists; }
        }

        /// <summary>
        /// Gets a value indicating whether the scroll bar exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the scroll bar exists; otherwise, <c>false</c>.
        /// </value>
        public bool ScrollBarExists
        {
            get { return Find<WpfScrollBar>(By.AutomationId("EaIQgF5jNk6XiSg6SO6d8A")).Exists; }
        }

        /// <summary>
        /// Gets a value indicating whether the scroll viewer exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the scroll viewer exists; otherwise, <c>false</c>.
        /// </value>
        public bool ScrollViewerExists
        {
            get { return Find<WpfPane>(By.AutomationId("DLFdnE5ogE26ZXPYTwiXjA")).Exists; }
        }

        /// <summary>
        /// Gets a value indicating whether the separator exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the separator exists; otherwise, <c>false</c>.
        /// </value>
        public bool SeparatorExists
        {
            get { return Find<WpfSeparator>(By.AutomationId("QtjLisTcxkmoC7Td8r4SRg")).Exists; }
        }

        /// <summary>
        /// Gets a value indicating whether the slider exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the slider exists; otherwise, <c>false</c>.
        /// </value>
        public bool SliderExists
        {
            get { return Find<WpfSlider>(By.AutomationId("fHu0DLdks0Oo46Zf-mLd7g")).Exists; }
        }

        /// <summary>
        /// Gets a value indicating whether the status bar exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the status bar exists; otherwise, <c>false</c>.
        /// </value>
        public bool StatusBarExists
        {
            get { return Find<WpfStatusBar>(By.AutomationId("is9FFBKLNkqy8YH80wCvOA")).Exists; }
        }

        /// <summary>
        /// Gets a value indicating whether the tab control exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the tab control exists; otherwise, <c>false</c>.
        /// </value>
        public bool TabControlExists
        {
            get { return Find<WpfTabList>(By.AutomationId("n7WYM4yUsk-pwCKVXDalZQ")).Exists; }
        }

        /// <summary>
        /// Gets a value indicating whether the text block exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the text block exists; otherwise, <c>false</c>.
        /// </value>
        public bool TextBlockExists
        {
            get { return Find<WpfText>(By.AutomationId("dCBRDmm9kEm2_u4Fdm9V4g")).Exists; }
        }

        /// <summary>
        /// Gets a value indicating whether the text box exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the text box exists; otherwise, <c>false</c>.
        /// </value>
        public bool TextBoxExists
        {
            get { return Find<WpfEdit>(By.AutomationId("fiJMHniwwE-AoTd66JyxBg")).Exists; }
        }

        /// <summary>
        /// Gets a value indicating whether the toggle button exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the toggle button exists; otherwise, <c>false</c>.
        /// </value>
        public bool ToggleButtonExists
        {
            get { return Find<WpfToggleButton>(By.AutomationId("eZq62SNMQ0S6wq0XRcFVxQ")).Exists; }
        }

        /// <summary>
        /// Gets a value indicating whether the tool bar exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the tool bar exists; otherwise, <c>false</c>.
        /// </value>
        public bool ToolBarExists
        {
            get { return Find<WpfToolBar>(By.AutomationId("AClh_S8BtEKS99-1gPOofQ")).Exists; }
        }

        /// <summary>
        /// Gets a value indicating whether the tree view exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the tree view exists; otherwise, <c>false</c>.
        /// </value>
        public bool TreeViewExists
        {
            get { return Find<WpfTree>(By.AutomationId("KDe9Dr8_kEuy9PZl5onvGQ")).Exists; }
        }
    }
}