namespace CUITe.IntegrationTests.NuGet
{
    using CUITe.Controls.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TestHelpers;

    [CodedUITest]
    public class HtmlTests
    {
        [TestMethod]
        public void SetText_OnHtmlEdit_Succeeds()
        {
            // Arrange
            using (var webPage = new TempWebPage(
@"<html>
    <head>
        <title>test</title>
    </head>
    <body>
        <input type=""text""/>
    </body>
</html>"))
            {
                var browserWindow = BrowserWindow.Launch(webPage.FilePath);
                HtmlEdit inputTextBox = browserWindow.Find<HtmlEdit>();

                // Act
                inputTextBox.Text = "text";

                // Assert
                Assert.AreEqual("text", inputTextBox.Text);

                browserWindow.Close();
            }
        }
    }
}
