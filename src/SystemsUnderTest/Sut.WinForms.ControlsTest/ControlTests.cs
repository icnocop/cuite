using System.Collections.Generic;
using CUITe.Controls;
using CUITe.Controls.WinControls;
using CUITe.ScreenObjects;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sut.WinForms.ControlsTest.ScreenObjects;

namespace Sut.WinForms.ControlsTest
{
    /// <summary>
    /// Control Tests
    /// </summary>
    [CodedUITest]
    [DeploymentItem("Sut.WinForms.Controls.exe")]
    public class ControlTests
    {
        private const string ApplicationFilePath = "Sut.WinForms.Controls.exe";
        private MainScreen mainScreen;

        /// <summary>
        /// Gets or sets the test context which provides information about and functionality for
        /// the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

        /// <summary>
        /// Initializes the test.
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            mainScreen = Screen.Launch<MainScreen>(ApplicationFilePath);
        }

        /// <summary>
        /// Button.
        /// </summary>
        [TestMethod]
        public void Button()
        {
            // Assert
            Assert.IsTrue(mainScreen.ButtonExists);
        }

        /// <summary>
        /// CheckBox.
        /// </summary>
        [TestMethod]
        public void CheckBox()
        {
            // Assert
            Assert.IsTrue(mainScreen.CheckBoxExists);
        }

        /// <summary>
        /// ComboBox.
        /// </summary>
        [TestMethod]
        public void ComboBox()
        {
            // Assert
            Assert.IsTrue(mainScreen.ComboBox.Exists);
        }

        /// <summary>
        /// Date time picker.
        /// </summary>
        [TestMethod]
        public void DateTimePicker()
        {
            // Assert
            Assert.IsTrue(mainScreen.DateTimePickerExists);
        }

        /// <summary>
        /// Group box.
        /// </summary>
        [TestMethod]
        public void GroupBox()
        {
            // Assert
            Assert.IsTrue(mainScreen.GroupBoxExists);
        }

        /// <summary>
        /// Label.
        /// </summary>
        [TestMethod]
        public void Label()
        {
            // Assert
            Assert.IsTrue(mainScreen.LabelExists);
        }

        /// <summary>
        /// Link label.
        /// </summary>
        [TestMethod]
        public void LinkLabel()
        {
            // Assert
            Assert.IsTrue(mainScreen.LinkLabelExists);
        }

        /// <summary>
        /// ListBox.
        /// </summary>
        [TestMethod]
        public void ListBox()
        {
            // Assert
            Assert.IsTrue(mainScreen.ListBoxExists);
        }

        /// <summary>
        /// ListView.
        /// </summary>
        [TestMethod]
        public void ListView()
        {
            // Assert
            Assert.IsTrue(mainScreen.ListViewExists);
        }

        /// <summary>
        /// Masked text box.
        /// </summary>
        [TestMethod]
        public void MaskedTextBox()
        {
            // Assert
            Assert.IsTrue(mainScreen.MaskedTextBox.Exists);
            Assert.AreEqual("This is a masked text box", mainScreen.MaskedTextBox.Text);
        }

        /// <summary>
        /// Month calendar.
        /// </summary>
        [TestMethod]
        public void MonthCalendar()
        {
            // Assert
            Assert.IsTrue(mainScreen.MonthCalendarExists);
        }

        /// <summary>
        /// Numeric up down.
        /// </summary>
        [TestMethod]
        public void NumericUpDown()
        {
            // Assert
            Assert.IsTrue(mainScreen.NumericUpDown.Exists);
            this.mainScreen.NumericUpDown.Click();
            Assert.AreEqual("25", mainScreen.NumericUpDown.Text);
        }

        /// <summary>
        /// Progress bar.
        /// </summary>
        [TestMethod]
        public void ProgressBar()
        {
            // Assert
            Assert.IsTrue(mainScreen.ProgressBarExists);
        }

        /// <summary>
        /// RadioButton.
        /// </summary>
        [TestMethod]
        public void RadioButton()
        {
            // Assert
            Assert.IsTrue(mainScreen.RadioButtonExists);
        }

        /// <summary>
        /// Rich text box.
        /// </summary>
        [TestMethod]
        public void RichTextBox()
        {
            // Assert
            Assert.IsTrue(mainScreen.RichTextBox.Exists);
            Assert.AreEqual("This is a rich text box\r", mainScreen.RichTextBox.Text);
        }

        /// <summary>
        /// Tab control.
        /// </summary>
        [TestMethod]
        public void TabControl()
        {
            // Assert
            Assert.IsTrue(mainScreen.TabControlExists);
        }

        /// <summary>
        /// Text box.
        /// </summary>
        [TestMethod]
        public void TextBox()
        {
            // Assert
            Assert.IsTrue(mainScreen.TextBox.Exists);
            Assert.AreEqual("This is a text box", mainScreen.TextBox.Text);
        }

        /// <summary>
        /// TreeView.
        /// </summary>
        [TestMethod]
        public void TreeView()
        {
            // Assert
            Assert.IsTrue(mainScreen.TreeViewExists);
        }

        /// <summary>
        /// Gets the children.
        /// </summary>
        [TestMethod]
        public void GetChildren()
        {
            List<ControlBase> children = mainScreen.GetChildrenOfTabControl();

            // Assert
            Assert.AreEqual(4, children.Count);

            Assert.AreEqual(typeof(WinTabPage).Name, children[0].GetType().Name);
            Assert.AreEqual("One", ((WinTabPage)children[0]).DisplayText);

            Assert.AreEqual(typeof(WinTabPage).Name, children[1].GetType().Name);
            Assert.AreEqual("Two", ((WinTabPage)children[1]).DisplayText);

            Assert.AreEqual(typeof(WinTabPage).Name, children[2].GetType().Name);
            Assert.AreEqual("Three", ((WinTabPage)children[2]).DisplayText);

            Assert.AreEqual(typeof(WinWindow).Name, children[3].GetType().Name);
            Assert.AreEqual("One", ((WinWindow)children[3]).GetProperty("Name"));
        }
    }
}