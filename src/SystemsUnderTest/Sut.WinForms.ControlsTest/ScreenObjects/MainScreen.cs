using System.Collections.Generic;
using System.Linq;
using CUITe.Controls;
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

        public WinComboBox ComboBox
        {
            get { return Find<WinComboBox>(By.ControlName("comboBox")); }
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

        public WinEdit MaskedTextBox
        {
            get { return Find<WinEdit>(By.ControlName("maskedTextBox")); }
        }

        public bool MonthCalendarExists
        {
            get { return Find<WinCalendar>(By.ControlName("monthCalendar")).Exists; }
        }

        public WinEdit NumericUpDown
        {
            get { return Find<WinEdit>(By.ControlName("numericUpDown")); }
        }

        public bool ProgressBarExists
        {
            get { return Find<WinProgressBar>(By.ControlName("progressBar")).Exists; }
        }

        public bool RadioButtonExists
        {
            get { return Find<WinRadioButton>(By.ControlName("radioButton")).Exists; }
        }

        public WinEdit RichTextBox
        {
            get { return Find<WinEdit>(By.ControlName("richTextBox")); }
        }

        public bool TabControlExists
        {
            get { return Find<WinTabList>(By.ControlName("tabControl")).Exists; }
        }

        public WinEdit TextBox
        {
            get { return Find<WinEdit>(By.ControlName("textBox")); }
        }

        public bool TreeViewExists
        {
            get { return Find<WinTree>(By.ControlName("treeView")).Exists; }
        }

        public List<ControlBase> GetChildrenOfTabControl()
        {
            return Find<WinTabList>(By.ControlName("tabControl")).GetChildren().ToList();
        }
    }
}