using CUITe.Controls.WinControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ControlsTest.ScreenObjects
{
    public class MainScreen : Screen
    {
        public bool ButtonExists
        {
            get { return Find<WinButton>(By.ControlName("button")).Exists; }
        }

        public bool CheckBoxExists
        {
            get { return Find<WinCheckBox>(By.ControlName("checkBox")).Exists; }
        }

        public bool ComboBoxExists
        {
            get { return Find<WinComboBox>(By.ControlName("comboBox")).Exists; }
        }

        public bool DateTimePickerExists
        {
            get { return Find<WinDateTimePicker>(By.ControlName("dateTimePicker")).Exists; }
        }

        public bool GroupBoxExists
        {
            get { return Find<WinGroup>(By.ControlName("groupBox")).Exists; }
        }

        public bool LabelExists
        {
            get { return Find<WinText>(By.ControlName("label")).Exists; }
        }

        public bool LinkLabelExists
        {
            get { return Find<WinText>(By.ControlName("linkLabel")).Exists; }
        }

        public bool ListBoxExists
        {
            get { return Find<WinList>(By.ControlName("listBox")).Exists; }
        }

        public bool ListViewExists
        {
            get { return Find<WinList>(By.ControlName("listView")).Exists; }
        }

        public bool MaskedTextBoxExists
        {
            get { return Find<WinText>(By.ControlName("maskedTextBox")).Exists; }
        }

        public bool MonthCalendarExists
        {
            get { return Find<WinDateTimePicker>(By.ControlName("monthCalendar")).Exists; }
        }

        public bool NumericUpDownExists
        {
            get { return Find<WinEdit>(By.ControlName("numericUpDown")).Exists; }
        }

        public bool ProgressBarExists
        {
            get { return Find<WinProgressBar>(By.ControlName("progressBar")).Exists; }
        }

        public bool RadioButtonExists
        {
            get { return Find<WinRadioButton>(By.ControlName("radioButton")).Exists; }
        }

        public bool RichTextBoxExists
        {
            get { return Find<WinEdit>(By.ControlName("richTextBox")).Exists; }
        }

        public bool TabControlExists
        {
            get { return Find<WinTabList>(By.ControlName("tabControl")).Exists; }
        }

        public bool TextBoxExists
        {
            get { return Find<WinEdit>(By.ControlName("textBox")).Exists; }
        }

        public bool TreeViewExists
        {
            get { return Find<WinTree>(By.ControlName("treeView")).Exists; }
        }
    }
}