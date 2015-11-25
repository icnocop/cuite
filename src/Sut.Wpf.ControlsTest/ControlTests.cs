using CUITe.ObjectRepository;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sut.Wpf.ControlsTest.ObjectRepository;

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
            Assert.IsTrue(mainScreen.Button.Exists);            
        }

        [TestMethod]
        public void Calendar()
        {
            // Assert
            Assert.IsTrue(mainScreen.Calendar.Exists);
        }

        [TestMethod]
        public void CheckBox()
        {
            // Assert
            Assert.IsTrue(mainScreen.CheckBox.Exists);
        }

        [TestMethod]
        public void ComboBox()
        {
            // Assert
            Assert.IsTrue(mainScreen.ComboBox.Exists);
        }

        [TestMethod]
        public void CustomControl()
        {
            // Assert
            Assert.IsTrue(mainScreen.CustomControl.Exists);
        }

        [TestMethod]
        public void DataGrid()
        {
            // Assert
            Assert.IsTrue(mainScreen.DataGrid.Exists);
        }

        [TestMethod]
        public void DatePicker()
        {
            // Assert
            Assert.IsTrue(mainScreen.DatePicker.Exists);
        }

        [TestMethod]
        public void Expander()
        {
            // Assert
            Assert.IsTrue(mainScreen.Expander.Exists);
        }

        [TestMethod]
        public void Frame()
        {
            // Assert
            Assert.IsTrue(mainScreen.Frame.Exists);
        }

        [TestMethod]
        public void GroupBox()
        {
            // Assert
            Assert.IsTrue(mainScreen.GroupBox.Exists);
        }

        [TestMethod]
        public void Hyperlink()
        {
            // Assert
            Assert.IsTrue(mainScreen.Hyperlink.Exists);
        }

        [TestMethod]
        public void Image()
        {
            // Assert
            Assert.IsTrue(mainScreen.Image.Exists);
        }

        [TestMethod]
        public void Label()
        {
            // Assert
            Assert.IsTrue(mainScreen.Label.Exists);
        }

        [TestMethod]
        public void ListBox()
        {
            // Assert
            Assert.IsTrue(mainScreen.ListBox.Exists);
        }

        [TestMethod]
        public void ListView()
        {
            // Assert
            Assert.IsTrue(mainScreen.ListView.Exists);
        }

        [TestMethod]
        public void Menu()
        {
            // Assert
            Assert.IsTrue(mainScreen.Menu.Exists);
        }

        [TestMethod]
        public void PasswordBox()
        {
            // Assert
            Assert.IsTrue(mainScreen.PasswordBox.Exists);
        }

        [TestMethod]
        public void ProgressBar()
        {
            // Assert
            Assert.IsTrue(mainScreen.ProgressBar.Exists);
        }

        [TestMethod]
        public void RadioButton()
        {
            // Assert
            Assert.IsTrue(mainScreen.RadioButton.Exists);
        }

        [TestMethod]
        public void RichTextBox()
        {
            // Assert
            Assert.IsTrue(mainScreen.RichTextBox.Exists);
        }

        [TestMethod]
        public void ScrollBar()
        {
            // Assert
            Assert.IsTrue(mainScreen.ScrollBar.Exists);
        }

        [TestMethod]
        public void ScrollViewer()
        {
            // Assert
            Assert.IsTrue(mainScreen.ScrollViewer.Exists);
        }

        [TestMethod]
        public void Separator()
        {
            // Assert
            Assert.IsTrue(mainScreen.Separator.Exists);
        }

        [TestMethod]
        public void Slider()
        {
            // Assert
            Assert.IsTrue(mainScreen.Slider.Exists);
        }

        [TestMethod]
        public void StatusBar()
        {
            // Assert
            Assert.IsTrue(mainScreen.StatusBar.Exists);
        }

        [TestMethod]
        public void TabControl()
        {
            // Assert
            Assert.IsTrue(mainScreen.TabControl.Exists);
        }

        [TestMethod]
        public void TextBlock()
        {
            // Assert
            Assert.IsTrue(mainScreen.TextBlock.Exists);
        }

        [TestMethod]
        public void TextBox()
        {
            // Assert
            Assert.IsTrue(mainScreen.TextBox.Exists);
        }

        [TestMethod]
        public void ToggleButton()
        {
            // Assert
            Assert.IsTrue(mainScreen.ToggleButton.Exists);
        }

        [TestMethod]
        public void ToolBar()
        {
            // Assert
            Assert.IsTrue(mainScreen.ToolBar.Exists);
        }

        [TestMethod]
        public void TreeView()
        {
            // Assert
            Assert.IsTrue(mainScreen.TreeView.Exists);
        }
    }
}