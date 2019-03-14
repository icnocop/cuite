using CUITe.ScreenObjects;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sut.Wpf.ControlsTest.ScreenObjects;

namespace Sut.Wpf.ControlsTest
{
    /// <summary>
    /// Control Tests
    /// </summary>
    [CodedUITest]
    [DeploymentItem("Sut.Wpf.Controls.exe")]
    [DeploymentItem("Sut.Wpf.Controls.exe")]
    public class ControlTests
    {
        private const string ApplicationFilePath = "Sut.Wpf.Controls.exe";
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
        /// Calendar.
        /// </summary>
        [TestMethod]
        public void Calendar()
        {
            // Assert
            Assert.IsTrue(mainScreen.CalendarExists);
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
            Assert.IsTrue(mainScreen.ComboBoxExists);
        }

        /// <summary>
        /// Custom control.
        /// </summary>
        [TestMethod]
        public void CustomControl()
        {
            // Assert
            Assert.IsTrue(mainScreen.CustomControlExists);
        }

        /// <summary>
        /// Data grid.
        /// </summary>
        [TestMethod]
        public void DataGrid()
        {
            // Assert
            Assert.IsTrue(mainScreen.DataGridExists);
        }

        /// <summary>
        /// Date picker.
        /// </summary>
        [TestMethod]
        public void DatePicker()
        {
            // Assert
            Assert.IsTrue(mainScreen.DatePickerExists);
        }

        /// <summary>
        /// Expander.
        /// </summary>
        [TestMethod]
        public void Expander()
        {
            // Assert
            Assert.IsTrue(mainScreen.ExpanderExists);
        }

        /// <summary>
        /// Frame.
        /// </summary>
        [TestMethod]
        public void Frame()
        {
            // Assert
            Assert.IsTrue(mainScreen.FrameExists);
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
        /// Hyperlink.
        /// </summary>
        [TestMethod]
        public void Hyperlink()
        {
            // Assert
            Assert.IsTrue(mainScreen.HyperlinkExists);
        }

        /// <summary>
        /// Image.
        /// </summary>
        [TestMethod]
        public void Image()
        {
            // Assert
            Assert.IsTrue(mainScreen.ImageExists);
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
        /// Menu.
        /// </summary>
        [TestMethod]
        public void Menu()
        {
            // Assert
            Assert.IsTrue(mainScreen.MenuExists);
        }

        /// <summary>
        /// Password box.
        /// </summary>
        [TestMethod]
        public void PasswordBox()
        {
            // Assert
            Assert.IsTrue(mainScreen.PasswordBoxExists);
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
            Assert.IsTrue(mainScreen.RichTextBoxExists);
        }

        /// <summary>
        /// Scroll bar.
        /// </summary>
        [TestMethod]
        public void ScrollBar()
        {
            // Assert
            Assert.IsTrue(mainScreen.ScrollBarExists);
        }

        /// <summary>
        /// Scroll viewer.
        /// </summary>
        [TestMethod]
        public void ScrollViewer()
        {
            // Assert
            Assert.IsTrue(mainScreen.ScrollViewerExists);
        }

        /// <summary>
        /// Separator.
        /// </summary>
        [TestMethod]
        public void Separator()
        {
            // Assert
            Assert.IsTrue(mainScreen.SeparatorExists);
        }

        /// <summary>
        /// Slider.
        /// </summary>
        [TestMethod]
        public void Slider()
        {
            // Assert
            Assert.IsTrue(mainScreen.SliderExists);
        }

        /// <summary>
        /// Status bar.
        /// </summary>
        [TestMethod]
        public void StatusBar()
        {
            // Assert
            Assert.IsTrue(mainScreen.StatusBarExists);
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
        /// Text block.
        /// </summary>
        [TestMethod]
        public void TextBlock()
        {
            // Assert
            Assert.IsTrue(mainScreen.TextBlockExists);
        }

        /// <summary>
        /// Text box.
        /// </summary>
        [TestMethod]
        public void TextBox()
        {
            // Assert
            Assert.IsTrue(mainScreen.TextBoxExists);
        }

        /// <summary>
        /// Toggle button.
        /// </summary>
        [TestMethod]
        public void ToggleButton()
        {
            // Assert
            Assert.IsTrue(mainScreen.ToggleButtonExists);
        }

        /// <summary>
        /// Tool bar.
        /// </summary>
        [TestMethod]
        public void ToolBar()
        {
            // Assert
            Assert.IsTrue(mainScreen.ToolBarExists);
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
    }
}