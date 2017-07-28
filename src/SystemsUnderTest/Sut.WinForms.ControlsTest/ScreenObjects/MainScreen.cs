using System.Collections.Generic;
using System.Linq;
using CUITe.Controls;
using CUITe.Controls.WinControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.ControlsTest.ScreenObjects
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
            get { return Find<WinWindow>(By.ControlName("button")).Find<WinButton>().Exists; }
        }

        /// <summary>
        /// Gets a value indicating whether the check box exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the check box exists; otherwise, <c>false</c>.
        /// </value>
        public bool CheckBoxExists
        {
            get { return Find<WinWindow>(By.ControlName("checkBox")).Find<WinCheckBox>().Exists; }
        }

        /// <summary>
        /// Gets the ComboBox.
        /// </summary>
        /// <value>
        /// The ComboBox.
        /// </value>
        public WinComboBox ComboBox
        {
            get { return Find<WinWindow>(By.ControlName("comboBox")).Find<WinComboBox>(); }
        }

        /// <summary>
        /// Gets a value indicating whether the date time picker exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the date time picker exists; otherwise, <c>false</c>.
        /// </value>
        public bool DateTimePickerExists
        {
            get { return Find<WinWindow>(By.ControlName("dateTimePicker")).Find<WinDateTimePicker>().Exists; }
        }

        /// <summary>
        /// Gets a value indicating whether the group box exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the group box exists; otherwise, <c>false</c>.
        /// </value>
        public bool GroupBoxExists
        {
            get { return Find<WinWindow>(By.ControlName("groupBox")).Find<WinGroup>().Exists; }
        }

        /// <summary>
        /// Gets a value indicating whether the label exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the label exists; otherwise, <c>false</c>.
        /// </value>
        public bool LabelExists
        {
            get { return Find<WinWindow>(By.ControlName("label")).Find<WinText>().Exists; }
        }

        /// <summary>
        /// Gets a value indicating whether the link label exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the link label exists; otherwise, <c>false</c>.
        /// </value>
        public bool LinkLabelExists
        {
            get { return Find<WinWindow>(By.ControlName("linkLabel")).Find<WinText>().Exists; }
        }

        /// <summary>
        /// Gets a value indicating whether the list box exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the list box exists; otherwise, <c>false</c>.
        /// </value>
        public bool ListBoxExists
        {
            get { return Find<WinWindow>(By.ControlName("listBox")).Find<WinList>().Exists; }
        }

        /// <summary>
        /// Gets a value indicating whether the list view exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the list view exists; otherwise, <c>false</c>.
        /// </value>
        public bool ListViewExists
        {
            get { return Find<WinWindow>(By.ControlName("listView")).Find<WinList>().Exists; }
        }

        /// <summary>
        /// Gets the masked text box.
        /// </summary>
        /// <value>
        /// The masked text box.
        /// </value>
        public WinEdit MaskedTextBox
        {
            get { return Find<WinWindow>(By.ControlName("maskedTextBox")).Find<WinEdit>(); }
        }

        /// <summary>
        /// Gets a value indicating whether the month calendar exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the month calendar exists; otherwise, <c>false</c>.
        /// </value>
        public bool MonthCalendarExists
        {
            get { return Find<WinWindow>(By.ControlName("monthCalendar")).Find<WinCalendar>().Exists; }
        }

        /// <summary>
        /// Gets the numeric up down.
        /// </summary>
        /// <value>
        /// The numeric up down.
        /// </value>
        public WinEdit NumericUpDown
        {
            get { return Find<WinWindow>(By.ControlName("numericUpDown")).Find<WinEdit>(); }
        }

        /// <summary>
        /// Gets a value indicating whether the progress bar exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the progress bar exists; otherwise, <c>false</c>.
        /// </value>
        public bool ProgressBarExists
        {
            get { return Find<WinWindow>(By.ControlName("progressBar")).Find<WinProgressBar>().Exists; }
        }

        /// <summary>
        /// Gets a value indicating whether the radio button exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the radio button exists; otherwise, <c>false</c>.
        /// </value>
        public bool RadioButtonExists
        {
            get { return Find<WinWindow>(By.ControlName("radioButton")).Find<WinRadioButton>().Exists; }
        }

        /// <summary>
        /// Gets the rich text box.
        /// </summary>
        /// <value>
        /// The rich text box.
        /// </value>
        public WinEdit RichTextBox
        {
            get { return Find<WinWindow>(By.ControlName("richTextBox")).Find<WinEdit>(); }
        }

        /// <summary>
        /// Gets a value indicating whether the tab control exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the tab control exists; otherwise, <c>false</c>.
        /// </value>
        public bool TabControlExists
        {
            get { return Find<WinWindow>(By.ControlName("tabControl")).Find<WinTabList>().Exists; }
        }

        /// <summary>
        /// Gets the text box.
        /// </summary>
        /// <value>
        /// The text box.
        /// </value>
        public WinEdit TextBox
        {
            get { return Find<WinWindow>(By.ControlName("textBox")).Find<WinEdit>(); }
        }

        /// <summary>
        /// Gets a value indicating whether the tree view exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the tree view exists; otherwise, <c>false</c>.
        /// </value>
        public bool TreeViewExists
        {
            get { return Find<WinWindow>(By.ControlName("treeView")).Find<WinTree>().Exists; }
        }

        /// <summary>
        /// Gets the children of tab control.
        /// </summary>
        /// <returns>The children</returns>
        public List<ControlBase> GetChildrenOfTabControl()
        {
            return Find<WinWindow>(By.ControlName("tabControl")).Find<WinTabList>().GetChildren().ToList();
        }
    }
}