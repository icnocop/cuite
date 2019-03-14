using System;
using System.Diagnostics;
using System.IO;
using CUITe.Browsers;
using CUITe.Controls.HtmlControls;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Win32;

namespace Sut.HtmlTest
{
    /// <summary>
    /// Cross-browser HTML Control Tests
    /// </summary>
    [CodedUITest]
    public class CrossBrowserHtmlControlTests
    {
        /// <summary>
        /// Sets the text on HTML edit using firefox succeeds.
        /// </summary>
        [TestMethod]
        public void SetText_OnHtmlEditUsingFirefox_Succeeds()
        {
            // get the version of Firefox
            string firefoxExeFilePath = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\firefox.exe", "", null);
            Assert.IsNotNull(firefoxExeFilePath);

            Version version = new Version(FileVersionInfo.GetVersionInfo(firefoxExeFilePath).FileVersion);
            Console.WriteLine("Firefox version: {0}", version);

            SetTextOnHtmlEdit(Firefox.Name);
        }

        /// <summary>
        /// Sets the text on HTML edit using chrome succeeds.
        /// </summary>
        [TestMethod]
        [Ignore] // Selenium components for Coded UI Cross Browser Testing v1.7 does not support Chrome 55
        // and Chrome 54 (GoogleChromeStandaloneEnterprise.msi) is no longer available for download
        public void SetText_OnHtmlEditUsingChrome_Succeeds()
        {
            // get the version of Chrome
            string registryPath = @"\Software\Microsoft\Windows\CurrentVersion\App Paths\chrome.exe";
            string chromeExeFilePath = (string)Registry.GetValue("HKEY_LOCAL_MACHINE" + registryPath, "", null);
            if (chromeExeFilePath == null)
            {
                // check HKEY_CURRENT_USER
                chromeExeFilePath = (string)Registry.GetValue("HKEY_CURRENT_USER" + registryPath, "", null);
            }

            Assert.IsNotNull(chromeExeFilePath);

            Version version = new Version(FileVersionInfo.GetVersionInfo(chromeExeFilePath).FileVersion);
            Console.WriteLine("Chrome version: {0}", version);

            SetTextOnHtmlEdit(Chrome.Name);
        }

        private void SetTextOnHtmlEdit(string browser)
        {
            //Arrange
            IBrowser previousBrowser = BrowserWindowUnderTest.GetCurrentBrowser();

            try
            {
                string tempFilePath = Path.GetTempFileName();

                File.WriteAllText(tempFilePath,
@"<html>
    <head>
        <title>test</title>
    </head>
    <body>
        <div id=""div1"">
            <input type=""text""/>
        </div>
    </body>
</html>");

                BrowserWindow.CurrentBrowser = browser;

                BrowserWindow window = BrowserWindow.Launch(tempFilePath);
                var div = window.Find<HtmlDiv>(By.Id("div1"));
                var inputTextBox = div.Find<HtmlEdit>();

                //Act
                inputTextBox.Text = "text";

                //Assert
                Assert.AreEqual("text", inputTextBox.Text);

                window.Close();

                File.Delete(tempFilePath);
            }
            finally
            {
                BrowserWindow.CurrentBrowser = previousBrowser.Name;
            }
        }
    }
}
