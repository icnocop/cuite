using System.IO;
using CUITe.Browsers;
using CUITe.Controls.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sample_CUITeTestProject
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
            IBrowser previousBrowser = CUITe_BrowserWindow.GetCurrentBrowser();

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

                CUITe_BrowserWindow window = CUITe_BrowserWindow.Launch(tempFilePath, "test");
                CUITe_HtmlDiv div = window.Get<CUITe_HtmlDiv>("id=div1");
                CUITe_HtmlEdit inputTextBox = div.Get<CUITe_HtmlEdit>();

                //Act
                inputTextBox.SetText("text");

                //Assert
                Assert.AreEqual("text", inputTextBox.GetText());

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
