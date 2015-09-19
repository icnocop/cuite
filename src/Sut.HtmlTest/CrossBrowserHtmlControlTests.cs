using System.IO;
using CUITe.Browsers;
using CUITe.Controls.HtmlControls;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sut.HtmlTest
{
    [CodedUITest]
    public class CrossBrowserHtmlControlTests
    {
        [TestMethod]
        public void SetText_OnHtmlEditUsingFirefox_Succeeds()
        {
            SetTextOnHtmlEdit(Firefox.Name);
        }

        [TestMethod]
        public void SetText_OnHtmlEditUsingChrome_Succeeds()
        {
            SetTextOnHtmlEdit(Chrome.Name);
        }

        public void SetTextOnHtmlEdit(string browser)
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

                BrowserWindowUnderTest window = BrowserWindowUnderTest.Launch(tempFilePath);
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
