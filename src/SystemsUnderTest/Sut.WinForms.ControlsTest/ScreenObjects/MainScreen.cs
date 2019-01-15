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
            get { return Find<WinWindow>(By.ControlName("button")).Find<WinButton>().Exists; }
        }

        public bool CheckBoxExists
        {
            get { return Find<WinWindow>(By.ControlName("checkBox")).Find<WinCheckBox>().Exists; }
        }

        public WinComboBox ComboBox
        {
            get { return Find<WinWindow>(By.ControlName("comboBox")).Find<WinComboBox>(); }
        }

        public bool DateTimePickerExists
        {
            get { return Find<WinWindow>(By.ControlName("dateTimePicker")).Find<WinDateTimePicker>().Exists; }
        }

        public bool GroupBoxExists
        {
            get { return Find<WinWindow>(By.ControlName("groupBox")).Find<WinGroup>().Exists; }
        }

        public bool LabelExists
        {
            get { return Find<WinWindow>(By.ControlName("label")).Find<WinText>().Exists; }
        }

        public bool LinkLabelExists
        {
            get { return Find<WinWindow>(By.ControlName("linkLabel")).Find<WinText>().Exists; }
        }

        public bool ListBoxExists
        {
            get { return Find<WinWindow>(By.ControlName("listBox")).Find<WinList>().Exists; }
        }

        public bool ListViewExists
        {
            get { return Find<WinWindow>(By.ControlName("listView")).Find<WinList>().Exists; }
        }

        public WinEdit MaskedTextBox
        {
            get { return Find<WinWindow>(By.ControlName("maskedTextBox")).Find<WinEdit>(); }
        }

        public bool MonthCalendarExists
        {
            get { return Find<WinWindow>(By.ControlName("monthCalendar")).Find<WinCalendar>().Exists; }
        }

        public WinEdit NumericUpDown
        {
            get { return Find<WinWindow>(By.ControlName("numericUpDown")).Find<WinEdit>(); }
        }

        public bool ProgressBarExists
        {
            get { return Find<WinWindow>(By.ControlName("progressBar")).Find<WinProgressBar>().Exists; }
        }

        public bool RadioButtonExists
        {
            get { return Find<WinWindow>(By.ControlName("radioButton")).Find<WinRadioButton>().Exists; }
        }

        public WinEdit RichTextBox
        {
            get { return Find<WinWindow>(By.ControlName("richTextBox")).Find<WinEdit>(); }
        }

        public bool TabControlExists
        {
            get { return Find<WinWindow>(By.ControlName("tabControl")).Find<WinTabList>().Exists; }
        }

        public WinEdit TextBox
        {
            get { return Find<WinWindow>(By.ControlName("textBox")).Find<WinEdit>(); }
        }

        public bool TreeViewExists
        {
            get { return Find<WinWindow>(By.ControlName("treeView")).Find<WinTree>().Exists; }
        }

        public List<ControlBase> GetChildrenOfTabControl()
        {
            return Find<WinWindow>(By.ControlName("tabControl")).Find<WinTabList>().GetChildren().ToList();
        }
    }
}