using CUITe.Controls.HtmlControls;
using CUITe.Controls.WinControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace CUITe.IntegrationTests.ObjectRecorder.Screens
{
    public class MainScreen : Screen
    {
        public WinButton RecordButton
        {
            get { return ToolStripToolBar.Find<WinButton>(By.Name("Record")); }
        }

        public WinEdit AddressTextBox
        {
            get { return MainWindow.Find<WinEdit>(By.Name("Address")); }
        }

        public WinButton GoButton
        {
            get { return MainWindow.Find<WinButton>(By.Name("Go")); }
        }

        private HtmlDocument HtmlDocument
        {
            get { return WebBrowser.Find<HtmlDocument>(); }
        }

        public HtmlEdit TestTextBox
        {
            get { return HtmlDocument.Find<HtmlEdit>(); }
        }

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
