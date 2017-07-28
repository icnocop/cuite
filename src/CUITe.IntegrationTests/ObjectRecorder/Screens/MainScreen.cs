using CUITe.Controls.HtmlControls;
using CUITe.Controls.WinControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace CUITe.IntegrationTests.ObjectRecorder.Screens
{
    /// <summary>
    /// Main Screen
    /// </summary>
    /// <seealso cref="CUITe.ScreenObjects.Screen" />
    public class MainScreen : Screen
    {
        /// <summary>
        /// Gets the record button.
        /// </summary>
        /// <value>
        /// The record button.
        /// </value>
        public WinButton RecordButton
        {
            get { return ToolStripToolBar.Find<WinButton>(By.Name("Record")); }
        }

        /// <summary>
        /// Gets the address text box.
        /// </summary>
        /// <value>
        /// The address text box.
        /// </value>
        public WinEdit AddressTextBox
        {
            get { return MainWindow.Find<WinEdit>(By.Name("Address")); }
        }

        /// <summary>
        /// Gets the go button.
        /// </summary>
        /// <value>
        /// The go button.
        /// </value>
        public WinButton GoButton
        {
            get { return MainWindow.Find<WinButton>(By.Name("Go")); }
        }

        private HtmlDocument HtmlDocument
        {
            get { return WebBrowser.Find<HtmlDocument>(); }
        }

        /// <summary>
        /// Gets the test text box.
        /// </summary>
        /// <value>
        /// The test text box.
        /// </value>
        public HtmlEdit TestTextBox
        {
            get { return HtmlDocument.Find<HtmlEdit>(); }
        }

        /// <summary>
        /// Gets the generate code button.
        /// </summary>
        /// <value>
        /// The generate code button.
        /// </value>
        public WinButton GenerateCodeButton
        {
            get { return ToolStripToolBar.Find<WinButton>(By.Name("GenerateCode")); }
        }

        private WinWindow MainWindow
        {
            get { return Find<WinWindow>(By.Name("CUITe_ObjectRecorder")); }
        }

        private WinToolBar ToolStripToolBar
        {
            get { return MainWindow.Find<WinToolBar>(By.Name("toolStrip1")); }
        }

        private WinClient WebBrowser
        {
            get { return MainWindow.Find<WinClient>(By.ClassName("Internet Explorer_Server")); }
        }
    }
}
