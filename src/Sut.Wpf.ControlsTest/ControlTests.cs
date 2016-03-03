using CUITe.ScreenObjects;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sut.Wpf.ControlsTest.ScreenObjects;

namespace Sut.Wpf.ControlsTest
{
    [CodedUITest]
#if DEBUG
    [DeploymentItem(@"..\..\..\Sut.Wpf.Controls\bin\Debug\Sut.Wpf.Controls.exe")]
#else
    [DeploymentItem(@"..\..\..\Sut.Wpf.Controls\bin\Release\Sut.Wpf.Controls.exe")]
#endif
    public class ControlTests
    {
        private const string ApplicationFilePath = @"Sut.Wpf.Controls.exe";
        private MainScreen mainScreen;

        /// <summary>
        /// Gets or sets the test context which provides information about and functionality for
        /// the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void TestInitialize()
        {
            mainScreen = Screen.Launch<MainScreen>(ApplicationFilePath);
        }

        [TestMethod]
        public void Button()
        {
            // Assert
            Assert.IsTrue(mainScreen.ButtonExists);            
        }

        [TestMethod]
        public void Calendar()
        {
            // Assert
            Assert.IsTrue(mainScreen.CalendarExists);
        }

        [TestMethod]
        public void CheckBox()
        {
            // Assert
            Assert.IsTrue(mainScreen.CheckBoxExists);
        }

        [TestMethod]
        public void ComboBox()
        {
            // Assert
            Assert.IsTrue(mainScreen.ComboBoxExists);
        }

        [TestMethod]
        public void CustomControl()
        {
            // Assert
            Assert.IsTrue(mainScreen.CustomControlExists);
        }

        [TestMethod]
        public void DataGrid()
        {
            // Assert
            Assert.IsTrue(mainScreen.DataGridExists);
        }

        [TestMethod]
        public void DatePicker()
        {
            // Assert
            Assert.IsTrue(mainScreen.DatePickerExists);
        }

        [TestMethod]
        public void Expander()
        {
            // Assert
            Assert.IsTrue(mainScreen.ExpanderExists);
        }

        [TestMethod]
        public void Frame()
        {
            // Assert
            Assert.IsTrue(mainScreen.FrameExists);
        }

        [TestMethod]
        public void GroupBox()
        {
            // Assert
            Assert.IsTrue(mainScreen.GroupBoxExists);
        }

        [TestMethod]
        public void Hyperlink()
        {
            // Assert
            Assert.IsTrue(mainScreen.HyperlinkExists);
        }

        [TestMethod]
        public void Image()
        {
            // Assert
            Assert.IsTrue(mainScreen.ImageExists);
        }

        [TestMethod]
        public void Label()
        {
            // Assert
            Assert.IsTrue(mainScreen.LabelExists);
        }

        [TestMethod]
        public void ListBox()
        {
            // Assert
            Assert.IsTrue(mainScreen.ListBoxExists);
        }

        [TestMethod]
        public void ListView()
        {
            // Assert
            Assert.IsTrue(mainScreen.ListViewExists);
        }

        [TestMethod]
        public void Menu()
        {
            // Assert
            Assert.IsTrue(mainScreen.MenuExists);
        }

        [TestMethod]
        public void PasswordBox()
        {
            // Assert
            Assert.IsTrue(mainScreen.PasswordBoxExists);
        }

        [TestMethod]
        public void ProgressBar()
        {
            // Assert
            Assert.IsTrue(mainScreen.ProgressBarExists);
        }

        [TestMethod]
        public void RadioButton()
        {
            // Assert
            Assert.IsTrue(mainScreen.RadioButtonExists);
        }

        [TestMethod]
        public void RichTextBox()
        {
            // Assert
            Assert.IsTrue(mainScreen.RichTextBoxExists);
        }

        [TestMethod]
        public void ScrollBar()
        {
            // Assert
            Assert.IsTrue(mainScreen.ScrollBarExists);
        }

        [TestMethod]
        public void ScrollViewer()
        {
            // Assert
            Assert.IsTrue(mainScreen.ScrollViewerExists);
        }

        [TestMethod]
        public void Separator()
        {
            // Assert
            Assert.IsTrue(mainScreen.SeparatorExists);
        }

        [TestMethod]
        public void Slider()
        {
            // Assert
            Assert.IsTrue(mainScreen.SliderExists);
        }

        [TestMethod]
        public void StatusBar()
        {
            // Assert
            Assert.IsTrue(mainScreen.StatusBarExists);
        }

        [TestMethod]
        public void TabControl()
        {
            // Assert
            Assert.IsTrue(mainScreen.TabControlExists);
        }

        [TestMethod]
        public void TextBlock()
        {
            // Assert
            Assert.IsTrue(mainScreen.TextBlockExists);
        }

        [TestMethod]
        public void TextBox()
        {
            // Assert
            Assert.IsTrue(mainScreen.TextBoxExists);
        }

        [TestMethod]
        public void ToggleButton()
        {
            // Assert
            Assert.IsTrue(mainScreen.ToggleButtonExists);
        }

        [TestMethod]
        public void ToolBar()
        {
            // Assert
            Assert.IsTrue(mainScreen.ToolBarExists);
        }

        [TestMethod]
        public void TreeView()
        {
            // Assert
            Assert.IsTrue(mainScreen.TreeViewExists);
        }
    }
}