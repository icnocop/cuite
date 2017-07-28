using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using CUITe.Browsers;
using CUITe.Controls;
using CUITe.Controls.HtmlControls;
using CUITe.Controls.WinControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sut.HtmlTest.PageObjects;
using TestHelpers;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace Sut.HtmlTest
{
    /// <summary>
    /// HTML Control Tests
    /// </summary>
    [CodedUITest]
    [DeploymentItem("TestHtmlPage.html")]
    public class HtmlControlTests
    {
        private readonly string currentDirectory = Directory.GetCurrentDirectory();

        /// <summary>
        /// Gets or sets the test context which provides information about and functionality for the current test run.
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global; MsTest requirements
        // ReSharper disable once MemberCanBePrivate.Global; MsTest requirements
        public TestContext TestContext { get; set; }

        /// <summary>
        /// Initializes the test.
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            //BrowserWindow.CloseAllBrowsers();
        }

        /// <summary>
        /// Runs after each test.
        /// </summary>
        [TestCleanup]
        public void TestCleanup()
        {
            Trace.WriteLine(string.Format("Test Results Directory: {0}", TestContext.TestResultsDirectory));
        }

        /// <summary>
        /// Sets the text on telerik aspnet ComboBox selects item by text.
        /// </summary>
        [TestMethod]
        public void SetText_OnTelerikASPNETComboBox_SelectsItemByText()
        {
            // Arrange
            var page = Page.Launch<TeleriksASPNETComboBoxPage>("http://demos.telerik.com/aspnet-ajax/combobox/examples/default/defaultcs.aspx");

            // Act
            page.Product.Text = "Tofu";
            Keyboard.SendKeys("{Tab}"); // close drop down menu
            page.Region.Text = "Bloomfield Hills";
            Keyboard.SendKeys("{Tab}"); // close drop down menu
            page.Dealer.Text = "Exotic Liquids";
            Keyboard.SendKeys("{Tab}"); // close drop down menu
            page.PaymentMethod.Click(); // America Express
            Keyboard.SendKeys("{Down}"); // MasterCard
            Keyboard.SendKeys("{Down}"); // Visa
            Keyboard.SendKeys("{Tab}"); // close drop down menu
        }

        /// <summary>
        /// Non existent HTML control does not exist.
        /// </summary>
        [TestMethod]
        public void HtmlControl_NonExistent_DoesNotExist()
        {
            //Arrange
            SmartMatchOptions smartMatchOptions = SmartMatchOptions.Control;

            try
            {
                //set SmartMatchOptions to None because we are using .Exists on an invalid control
                //remember previous setting so that it can be reset
                smartMatchOptions = Playback.PlaybackSettings.SmartMatchOptions;
                Playback.PlaybackSettings.SmartMatchOptions = SmartMatchOptions.None;

                using (var webPage = new TempWebPage(
@"<html>
    <head>
        <title>test</title>
    </head>
    <body>
    </body>
</html>"))
                {
                    var browserWindow = BrowserWindow.Launch(webPage.FilePath);
                    
                    //Act
                    HtmlDiv div = browserWindow.Find<HtmlDiv>(By.Id("invalid"));

                    //Assert
                    Assert.IsFalse(div.Exists);

                    browserWindow.Close();
                }
            }
            finally
            {
                //reset default setting
                Playback.PlaybackSettings.SmartMatchOptions = smartMatchOptions;
            }
        }

        /// <summary>
        /// Get column headers for an HTML table.
        /// </summary>
        [TestMethod]
        public void HtmlTable_GetColumnHeaders_Succeeds()
        {
            var browserWindow = BrowserWindow.Launch(currentDirectory + "/TestHtmlPage.html");
            var tbl = browserWindow.Find<HtmlTable>(By.Id("calcWithHeaders"));
            string[] saExpectedValues = { "Header1", "Header2", "Header3" };
            string[] saHeaders = tbl.GetColumnHeaders();
            Assert.AreEqual(saExpectedValues[0], saHeaders[0]);
            Assert.AreEqual(saExpectedValues[1], saHeaders[1]);
            Assert.AreEqual(saExpectedValues[2], saHeaders[2]);
            browserWindow.Close();
        }

        /// <summary>
        /// Finds and clicks the header for an HTML table.
        /// </summary>
        [TestMethod]
        public void HtmlTable_FindHeaderAndClick_Succeeds()
        {
            //Arrange
            using (var webPage = new TempWebPage(
@"<html>
    <head>
        <title>test</title>
    </head>
    <body>
        <table style=""width: 100%;"" id=""tableId"">
            <tbody>
                <tr>
                    <td>Commitment</td>
                    <th>September</th>
                    <th>October</th>
                    <th>November</th>
                    <td>Total</td>
                </tr>
                <tr>
                    <td>Beginning Balance</td>
                    <td>¥21,570,253</td>
                    <td>¥21,375,491</td>
                    <td>¥21,200,873</td>
                    <td></td>
                </tr>
                <tr>
                    <td>New Purchases</td>
                    <td>¥0</td>
                    <td>¥0</td>
                    <td>¥0</td>
                    <td></td>
                </tr>
                <tr>
                    <td>Utilized</td>
                    <td>¥194,762</td>
                    <td>¥174,618</td>
                    <td>¥0</td>
                    <td>¥369,380</td>
                </tr>
                <tr>
                    <td>Ending Balance</td>
                    <td>¥21,375,491</td>
                    <td>¥21,200,873</td>
                    <td>¥21,200,873</td>
                    <td></td>
                </tr>
                <tr>
                    <td><b>Overage</b></td> 
                    <td>¥0</td>
                    <td>¥0</td>
                    <td>¥0</td>
                    <td>¥0</td>
                    <td></td>
                </tr>
                <tr>
                    <td><b>Total Usage</b></td>
                    <td>¥194,762</td>
                    <td>¥174,618</td>
                    <td>¥0</td>
                    <td>¥369,380</td>
                </tr>
            </tbody>
        </table>
    </body>
</html>"))
            {

                var browserWindow = BrowserWindow.Launch(webPage.FilePath);
                
                var table = browserWindow.Find<HtmlTable>(By.Id("tableId"));

                //Act
                table.FindHeaderCellAndClick(0, 2);

                browserWindow.Close();
            }
        }

        /// <summary>
        /// Counts the columns on an HTML table.
        /// </summary>
        [TestMethod]
        public void HtmlTable_ColumnCount_Succeeds()
        {
            var browserWindow = BrowserWindow.Launch(currentDirectory + "/TestHtmlPage.html");
            var tbl = browserWindow.Find<HtmlTable>(By.Id("calcWithHeaders"));
            Assert.AreEqual(3, tbl.ColumnCount);
            browserWindow.Close();
        }

        /// <summary>
        /// Clicks on a column header on an HTML table.
        /// </summary>
        [TestMethod]
        public void HtmlTable_ClickOnColumnHeader_Succeeds()
        {
            // allow Internet Explorer to run JavaScript
            var runResult = ProcessRunner.Run("icacls.exe", string.Format("\"{0}\" /setintegritylevel (CI)(OI)Low", currentDirectory));
            Assert.AreEqual(0, runResult.ExitCode);

            var browserWindow = BrowserWindow.Launch(currentDirectory + "/TestHtmlPage.html");
            var tbl = browserWindow.Find<HtmlTable>(By.Id("tableWithAlertOnHeaderClick"));
            tbl.FindHeaderCellAndClick(0, 0);
            browserWindow.PerformDialogAction(BrowserDialogAction.Ok);
            browserWindow.Close();
        }

        /// <summary>
        /// Finds a row using an HTML table with row headers.
        /// </summary>
        [TestMethod]
        [WorkItem(638)]
        public void HtmlTable_FindRowUsingTableWithRowHeaders_Succeeds()
        {
            var bWin = BrowserWindow.Launch(currentDirectory + "/TestHtmlPage.html");
            var tbl = bWin.Find<HtmlTable>(By.Id("calcWithHeaders"));
            tbl.FindRowAndClick("9", 2, HtmlTableSearchOptions.NormalTight);
            Assert.AreEqual("9", tbl.GetCellValue(3, 2).Trim());
            bWin.Close();
        }

        /// <summary>
        /// Finds a row using an HTML table without row headers.
        /// </summary>
        [TestMethod]
        [WorkItem(638)]
        public void HtmlTable_FindRowUsingTableWithoutRowHeaders_Succeeds()
        {
            var bWin = BrowserWindow.Launch(currentDirectory + "/TestHtmlPage.html");
            var tbl = bWin.Find<HtmlTable>(By.Id("calcWithOutHeaders"));
            tbl.FindRowAndClick("9", 2, HtmlTableSearchOptions.NormalTight);
            Assert.AreEqual("9", tbl.GetCellValue(2, 2).Trim());
            bWin.Close();
        }

        /// <summary>
        /// Gets the cell value using an HTML table with header cell.
        /// </summary>
        [TestMethod]
        public void HtmlTable_GetCellValueWithHeaderCell_Succeeds()
        {
            var bWin = BrowserWindow.Launch(currentDirectory + "/TestHtmlPage.html");

            var termTable = bWin.Find<HtmlTable>(By.Id("calcWithHeaderCells"));

            Assert.AreEqual("3", termTable.GetCellValue(1, 1));

            bWin.Close();
        }

        /// <summary>
        /// Gets the cell value using an HTML table with TH in TBODY succeeds.
        /// </summary>
        [TestMethod]
        public void HtmlTable_GetCellValueUsingTableWithTHInTBODY_Succeeds()
        {
            //Arrange
            using (var webPage = new TempWebPage(
@"<html>
    <head>
        <title>test</title>
    </head>
    <body>
        <table id=""tableId"" border=""1"">
            <tbody>
                <tr>
                    <th>Lun</th>
                    <th>Used Space</th>
                    <th>Free Space</th>
                    <th>Usage %</th>
                    <th>&nbsp;</th>
                </tr>
                <tr>
                    <td>LUN_04</td>
                    <td>26534605227</td>
                    <td>15405750418</td>
                    <td>
                        <dl>
                            <dd>
                                <dl>
                                    <dd>
                                        <span>64.27%</span>
                                    </dd>
                                </dl>
                            </dd>
                        </dl>
                    </td>
                    <td></td>
                </tr>
            </tbody>
        </table>
    </body>
</html>"))
            {
                var browserWindow = BrowserWindow.Launch(webPage.FilePath);
                
                var table = browserWindow.Find<HtmlTable>(By.Id("tableId"));

                //Act
                table.FindRowAndClick("LUN_04", 0, HtmlTableSearchOptions.NormalTight);

                //Assert
                Assert.AreEqual("LUN_04", table.GetCellValue(1, 0).Trim());

                browserWindow.Close();
            }
        }

        /// <summary>
        /// Find HTML input button using a search property with the value as key succeeds.
        /// </summary>
        [TestMethod]
        public void HtmlInputButton_UsingSearchPropertyWithValueAsKey_Succeeds()
        {
            //Internet Explorer may display the message: Internet Explorer restricted this webpage from running scripts or ActiveX controls.
            //This security restriction prevents the alert message to appear.
            //To enable running scripts on the local computer, go to Tools > Internet options > Advanced > Security > [checkmark] Allow active content to run in files on My Computer

            //Arrange
            using (var webPage = new TempWebPage(
@"<html>
    <head>
        <title>test</title>
    </head>
    <body>
        <input type=""submit"" value=""Log In"" onclick=""alert('onclick');""/>
    </body>
</html>"))
            {
                var browserWindow = BrowserWindow.Launch(webPage.FilePath);
                
                HtmlInputButton button = browserWindow.Find<HtmlInputButton>(By.ValueAttribute("Log In"));

                //Act
                button.Click();

                if (BrowserWindowUnderTest.GetCurrentBrowser() is InternetExplorer)
                {
                    //read JavaScript alert text
                    WinWindow popup = new WinWindow(By.Name("Message from webpage").AndClassName("#32770"));
                    WinText text = popup.Find<WinText>();
                    Assert.AreEqual("onclick", text.DisplayText);
                }

                browserWindow.PerformDialogAction(BrowserDialogAction.Ok);

                browserWindow.Close();
            }
        }

        /// <summary>
        /// Points and clicks on an HTML input button.
        /// </summary>
        [TestMethod]
        public void PointAndClick_OnHtmlInputButton_Succeeds()
        {
            //Arrange
            using (var webPage = new TempWebPage(
@"<html>
    <head>
        <title>test</title>
    </head>
    <body>
        <input type=""submit"" value=""Log In"" onclick=""alert('onclick');""/>
    </body>
</html>"))
            {
                var browserWindow = BrowserWindow.Launch(webPage.FilePath);
                
                HtmlInputButton button = browserWindow.Find<HtmlInputButton>(By.ValueAttribute("Log In"));

                //Act
                button.PointAndClick();

                browserWindow.PerformDialogAction(BrowserDialogAction.Ok);

                browserWindow.Close();
            }
        }

        /// <summary>
        /// Sets the file on an HTML file input box.
        /// </summary>
        [TestMethod]
        public void HtmlFileInput_SetFile_Succeeds()
        {
            //Arrange
            using (var webPage = new TempWebPage(
@"<html>
    <head>
        <title>test</title>
    </head>
    <body>
        <input name=""inputName"" type=""file"" id=""inputId"" />
    </body>
</html>"))
            {
                var browserWindow = BrowserWindow.Launch(webPage.FilePath);
                
                HtmlFileInput fileInput = browserWindow.Find<HtmlFileInput>(By.Id("inputId"));

                string tempInputFilePath = Path.GetTempFileName();

                //Act
                fileInput.FileName = tempInputFilePath;

                browserWindow.Close();

                File.Delete(tempInputFilePath);
            }
        }

        /// <summary>
        /// Finds an HTML hyperlink on Share Point 2010.
        /// </summary>
        [TestMethod]
        [Ignore]
        public void HtmlHyperlink_OnSharePoint2010_Succeeds()
        {
            var browserWindow = BrowserWindow.Launch("http://myasia/sites/sureba/Default.aspx");
            BrowserWindowUnderTest.Authenticate("username", "passwd");
            browserWindow.Find<HtmlHyperlink>(By.Id("idHomePageNewDocument")).Click();
            var closeLink = browserWindow.Find<HtmlHyperlink>(By.SearchProperties("Title=Close;class=ms-dlgCloseBtn"));
            //clicking closeLink directly doesn't work as the maximizeLink is clicked due to the controls being placed too close to each other
            Mouse.Click(closeLink.SourceControl.GetChildren()[0].GetChildren()[0]); 
            InternetExplorer.RunScript(browserWindow, @"STSNavigate2(event,'/sites/sureba/_layouts/SignOut.aspx');");
        }

        /// <summary>
        /// Gets the children of an HTML control.
        /// </summary>
        [TestMethod]
        public void HtmlControl_GetChildren_Succeeds()
        {
            var bWin = BrowserWindow.Launch(currentDirectory + "/TestHtmlPage.html");
            var div = bWin.Find<HtmlDiv>(By.Id("calculatorContainer1"));
            var col = div.GetChildren();
            Assert.IsTrue(col.ElementAt(0).SourceControlType.Name == "HtmlDiv");
            Assert.IsTrue(col.ElementAt(1).SourceControlType.Name == "HtmlTable");
            Assert.IsTrue(((HtmlDiv)col.ElementAt(0)).InnerText == "calcWithHeaders");
            var tbl = (HtmlTable)col.ElementAt(1);
            Assert.AreEqual("6", tbl.GetCellValue(2, 2).Trim());
            bWin.Close();
        }

        /// <summary>
        /// Gets the inner text of an HTML paragraph.
        /// </summary>
        [TestMethod]
        public void HtmlParagraph_InnertText_Succeeds()
        {
            var bWin = BrowserWindow.Launch(currentDirectory + "/TestHtmlPage.html");
            Assert.IsTrue(bWin.Find<HtmlParagraph>(By.Id("para1")).InnerText.Contains("HtmlParagraph"));
            bWin.Close();
        }

        /// <summary>
        /// Gets the items of an HTML combo box.
        /// </summary>
        [TestMethod]
        public void HtmlComboBox_Items_Succeeds()
        {
            //Arrange
            using (var webPage = new TempWebPage(
@"<html>
    <head>
        <title>test</title>
    </head>
    <body>
        <select id=""selectId"">
            <option>Cricket</option>
            <option>Football</option>
            <option>Tennis</option>
        </select>
    </body>
</html>"))
            {
                var browserWindow = BrowserWindow.Launch(webPage.FilePath);
                
                //Act
                HtmlComboBox comboBox = browserWindow.Find<HtmlComboBox>(By.Id("selectId"));

                //Assert
                Assert.AreEqual("Football", comboBox.Items[1]);
                Assert.IsTrue(comboBox.Items.Contains("Cricket"));

                browserWindow.Close();
            }
        }

        /// <summary>
        /// Selects the item by index on an HTML ComboBox.
        /// </summary>
        [TestMethod]
        public void SelectItem_ByIndexOnHtmlComboBox_Succeeds()
        {
            //Arrange
            using (var webPage = new TempWebPage(
@"<html>
    <head>
        <title>test</title>
    </head>
    <body>
        <select id=""selectId"">
            <option>Cricket</option>
            <option>Football</option>
            <option>Tennis</option>
        </select>
    </body>
</html>"))
            {
                var browserWindow = BrowserWindow.Launch(webPage.FilePath);
                
                //Act
                HtmlComboBox comboBox = browserWindow.Find<HtmlComboBox>(By.Id("selectId"));

                comboBox.SelectIndex(1);

                //Assert
                Assert.AreEqual("Football", comboBox.SelectedItem);

                browserWindow.Close();
            }
        }

        /// <summary>
        /// Gets the inner text of an HTML paragraph using page objects.
        /// </summary>
        [TestMethod]
        public void HtmlParagraph_PageObjects_Succeeds()
        {
            var page = Page.Launch<TestHtmlPage>(currentDirectory + "/TestHtmlPage.html");
            string content = page.Paragraph.InnerText;
            Assert.IsTrue(content.Contains("HtmlParagraph"));
        }

        /// <summary>
        /// Traverses siblings, parents, and children on an HTML paragraph.
        /// </summary>
        [TestMethod]
        public void HtmlParagraph_TraverseSiblingsParentAndChildren_Succeeds()
        {
            var bWin = BrowserWindow.Launch(currentDirectory + "/TestHtmlPage.html");
            var p = bWin.Find<HtmlParagraph>(By.Id("para1"));
            Assert.IsTrue(((HtmlEdit)p.PreviousSibling).SourceControl.Name == "text1_test");
            Assert.IsTrue(((HtmlInputButton)p.NextSibling).ValueAttribute == "sample button");
            Assert.IsTrue(((HtmlDiv)p.Parent).SourceControl.Id == "parentdiv");
            Assert.IsTrue(((HtmlPassword)p.Parent.FirstChild).SourceControl.Name == "pass");
            bWin.Close();
        }

        /// <summary>
        /// Clicks an HTML input button in an iframe.
        /// </summary>
        [TestMethod]
        [DeploymentItem("iframe_test.html")]
        [DeploymentItem("iframe.html")]
        public void HtmlInputButton_ClickInIFrame_Succeeds()
        {
            var bWin = BrowserWindow.Launch(currentDirectory + "/iframe_test.html");
            bWin.Find<HtmlInputButton>(By.ValueAttribute("Log In")).Click();
            bWin.Close();
        }

        /// <summary>
        /// Clicks an HTML input button in a CUITe iframe.
        /// </summary>
        [TestMethod]
        [DeploymentItem("iframe_test.html")]
        [DeploymentItem("iframe.html")]
        public void HtmlInputButton_ClickInCUITeIFrame_Succeeds()
        {
            var bWin = BrowserWindow.Launch(currentDirectory + "/iframe_test.html");
            HtmlIFrame iFrame = bWin.Find<HtmlIFrame>();
            iFrame.Find<HtmlInputButton>(By.ValueAttribute("Log In")).Click();
            bWin.Close();
        }

        /// <summary>
        /// Gets the HTML input button with a value containing whitespace.
        /// </summary>
        [TestMethod]
        [WorkItem(882)]
        public void HtmlInputButton_GetWithValueContainingWhitespace_Succeeds()
        {
            //Arrange
            using (var webPage = new TempWebPage(
@"<html>
    <head>
        <title>test</title>
    </head>
    <body>
        <input name=""inputName"" type=""submit"" value=""   Search   "" />
    </body>
</html>"))
            {
                var browserWindow = BrowserWindow.Launch(webPage.FilePath);
                
                HtmlInputButton button = browserWindow.Find<HtmlInputButton>(By.ValueAttribute("   Search   "));

                //Act
                button.Click();

                browserWindow.Close();
            }
        }

        /// <summary>
        /// Finds an HTML button hidden by style.
        /// </summary>
        [TestMethod]
        [Ignore] // this test currently fails
        public void HtmlButton_HiddenByStyle_ControlExistsAndCanAssertOnStyle()
        {
            //Arrange
            using (var webPage = new TempWebPage(
@"<html>
    <head>
        <title>test</title>
    </head>
    <body>
        <button id=""buttonId"" style=""display: none;"" >Hidden</button>
    </body>
</html>"))
            {
                var browserWindow = BrowserWindow.Launch(webPage.FilePath);
                
                //Act
                HtmlButton button = browserWindow.Find<HtmlButton>(By.Id("buttonId"));

                //Assert
                Assert.IsTrue(button.Exists);

                Assert.IsTrue(button.SourceControl.ControlDefinition.Contains("style=\"display: none;\""));

                browserWindow.Close();
            }
        }

        /// <summary>
        /// Finds an HTML unordered list and gets the inner text of its children.
        /// </summary>
        [TestMethod]
        public void HtmlUnorderedList_WithListItems_CanAssertOnListItems()
        {
            // Arrange
            var window = BrowserWindow.Launch(currentDirectory + "/TestHtmlPage.html");
            var list = window.Find<HtmlUnorderedList>(By.Id("unorderedList"));

            // Act
            List<HtmlCustomListItem> children = list.GetChildren()
                .Cast<HtmlCustomListItem>()
                .ToList();

            // Assert
            Assert.AreEqual(3, children.Count);
            Assert.AreEqual("List Item 1", children.ElementAt(0).InnerText.Trim());
            Assert.AreEqual("List Item 2", children.ElementAt(1).InnerText.Trim());
            Assert.AreEqual("List Item 3", children.ElementAt(2).InnerText.Trim());
            
            window.Close();
        }

        /// <summary>
        /// Gets an HTML unordered list using page objects and gets the inner text of its children.
        /// </summary>
        [TestMethod]
        public void HtmlUnorderedList_PageObjects_WithListItems_CanAssertOnListItems()
        {
            // Arrange
            var page = Page.Launch<TestHtmlPage>(currentDirectory + "/TestHtmlPage.html");

            // Act
            List<HtmlCustomListItem> children = page.List.GetChildren()
                .Cast<HtmlCustomListItem>()
                .ToList();

            // Assert
            Assert.AreEqual(3, children.Count());
            Assert.AreEqual("List Item 1", children.ElementAt(0).InnerText.Trim());
            Assert.AreEqual("List Item 2", children.ElementAt(1).InnerText.Trim());
            Assert.AreEqual("List Item 3", children.ElementAt(2).InnerText.Trim());
        }

        /// <summary>
        /// Finds an HTML check box disabled by style and its checked state.
        /// </summary>
        [TestMethod]
        public void HtmlCheckBox_DisabledByStyle_ControlExistsAndCanGetCheckedState()
        {
            //Arrange
            using (var webPage = new TempWebPage(
@"<html>
    <head>
        <title>test</title>
    </head>
    <body>
        <input type=""checkbox"" id=""checkBoxId"" disabled=""disabled"" name=""checkBoxName"" checked=""checked"" />
    </body>
</html>"))
            {
                var browserWindow = BrowserWindow.Launch(webPage.FilePath);
                
                //Act
                HtmlCheckBox checkBox = browserWindow.Find<HtmlCheckBox>(By.Id("checkBoxId"));

                //Assert
                Assert.IsTrue(checkBox.Exists);
                Assert.IsTrue(checkBox.Checked);

                browserWindow.Close();
            }
        }

        /// <summary>
        /// Selects an HTML combo box item.
        /// </summary>
        [TestMethod]
        public void SelectItem_UsingHtmlComboBoxThatAlertsOnChange_Succeeds()
        {
            //Arrange
            using (var webPage = new TempWebPage(
@"<html>
    <head>
        <title>test</title>
    </head>
    <body>
        <select id=""selectId"" onchange=""alert('onchange');"">
            <option>Apple</option>
            <option>Banana</option>
            <option>Carrot</option>
        </select>
    </body>
</html>"))
            {
                var window = BrowserWindow.Launch(webPage.FilePath);

                HtmlComboBox comboBox = window.Find<HtmlComboBox>(By.Id("selectId"));

                comboBox.SetFocus();

                //Act
                // select item "Banana"
                Keyboard.SendKeys(comboBox.SourceControl, "{DOWN}");

                window.PerformDialogAction(BrowserDialogAction.Ok);

                window.Close();
            }
        }

        /// <summary>
        /// Sets the text on an HTML edit box.
        /// </summary>
        [TestMethod]
        public void SetText_OnHtmlEdit_Succeeds()
        {
            //Arrange
            using (var webPage = new TempWebPage(
@"<html>
    <head>
        <title>test</title>
    </head>
    <body>
        <div id=""div1"">
            <input type=""text""/>
        </div>
    </body>
</html>"))
            {
                var browserWindow = BrowserWindow.Launch(webPage.FilePath);
                HtmlDiv div = browserWindow.Find<HtmlDiv>(By.Id("div1"));
                HtmlEdit inputTextBox = div.Find<HtmlEdit>();

                //Act
                inputTextBox.Text = "text";

                //Assert
                Assert.AreEqual("text", inputTextBox.Text);

                browserWindow.Close();
            }
        }

        /// <summary>
        /// Finds an HTML5 control.
        /// </summary>
        [TestMethod]
        [Ignore] // this test currently fails
        public void GetHtmlControl_OnHtml5Control_Succeeds()
        {
            // Arrange
            using (var webPage = new TempWebPage(
@"<html>
    <head>
        <title>test</title>
    </head>
    <body>
        <div class=""textbox"" id=""idDiv_PWD_UsernameTb"" style=""margin-bottom: 8px;"">
            <div style=""width: 100%; position: relative;"">
                <input name=""login"" id=""i0116"" style=""ime-mode: inactive;"" type=""email"" maxLength=""113""/>
                <div class=""phholder"" style=""left: 0px; top: 0px; width: 100%; position: absolute; z-index: 5;"">
                    <div class=""placeholder"" id=""idDiv_PWD_UsernameExample"" style=""cursor: text;"">
                    Text - someone@example.com
                    </div>
                </div>
            </div>
    </body>
</html>"))
            {
                var bWin = BrowserWindow.Launch(webPage.FilePath);

                // Act
                HtmlCustom txtUserName = bWin.Find<HtmlCustom>(By.Id("i0116").AndTagName("input"));
                
                // Assert
                Assert.IsTrue(txtUserName.Exists);

                Keyboard.SendKeys(txtUserName.SourceControl, "hello");

                //Assert
                Assert.AreEqual("hello", txtUserName.ValueAttribute);

                bWin.Close();
            }
        }

        /// <summary>
        /// Gets the selected items on an HTML list.
        /// </summary>
        [TestMethod]
        public void SelectedItems_OnHtmlList_Succeeds()
        {
            //Arrange
            using (var webPage = new TempWebPage(
@"<html>
    <head>
        <title>test</title>
    </head>
    <body>
        <select id=""selectId"" multiple=""multiple"">
            <option value=""1"">1</option>
            <option value=""2"">2</option>
            <option value=""3"">3</option>
        </select>
    </body>
</html>"))
            {
                var browserWindow = BrowserWindow.Launch(webPage.FilePath);
                HtmlList list = browserWindow.Find<HtmlList>(By.Id("selectId"));

                string[] itemsToSelect = { "1", "2" };

                //Act
                list.SelectedItems = itemsToSelect;

                //Assert
                CollectionAssert.AreEqual(itemsToSelect, list.SelectedItems);

                browserWindow.Close();
            }
        }

        /// <summary>
        /// Clicks on the HTML input button with an equals sign in the search property value.
        /// </summary>
        [TestMethod]
        public void Click_OnHtmlInputButtonWithEqualsSignInSearchPropertyValue_Succeeds()
        {
            //Arrange
            using (var webPage = new TempWebPage(
@"<html>
    <head>
        <title>test</title>
    </head>
    <body>
        <input type=""submit"" value=""="" onclick=""alert('onclick');""/>
    </body>
</html>"))
            {
                var browserWindow = BrowserWindow.Launch(webPage.FilePath);
                
                HtmlInputButton button = browserWindow.Find<HtmlInputButton>(By.ValueAttribute("="));

                //Act
                button.Click();

                browserWindow.PerformDialogAction(BrowserDialogAction.Ok);

                browserWindow.Close();
            }
        }

        /// <summary>
        /// Finds the inner text in an HTML combo box with disabled items.
        /// </summary>
        [TestMethod]
        public void InnerText_OnHtmlComboBoxWithDisabledItems_Succeeds()
        {
            //Arrange
            using (var webPage = new TempWebPage(
@"<html>
    <head>
        <title>test</title>
    </head>
    <body>
        <select id=""selectId"">
            <option value=""1"">1</option>
            <option value=""2"" disabled=""disabled"">2</option>
            <option value=""3"" disabled=""disabled"">3</option>
        </select>
    </body>
</html>"))
            {
                var browserWindow = BrowserWindow.Launch(webPage.FilePath);
                
                HtmlComboBox comboBox = browserWindow.Find<HtmlComboBox>(By.Id("selectId"));
                
                //Assert
                Assert.AreEqual(3, comboBox.ItemCount);
                CollectionAssert.AreEqual(new[] { "1", "2", "3" }, comboBox.Items);
                Assert.AreEqual("1 2 3", comboBox.InnerText.Trim());

                browserWindow.Close();
            }
        }

        /// <summary>
        /// Gets an HTML label's for attribute.
        /// </summary>
        [TestMethod]
        public void LabelFor_OnHtmlLabel_Succeeds()
        {
            //Arrange
            using (var webPage = new TempWebPage(
@"<html>
    <head>
        <title>test</title>
    </head>
    <body>
        <form>
          <label for=""male"">Male</label>
          <input type=""radio"" name=""sex"" id=""male"" value=""male""><br>
          <label for=""female"">Female</label>
          <input type=""radio"" name=""sex"" id=""female"" value=""female""><br>
          <label id=""other"" for=""other"">Other</label>
          <input type=""radio"" name=""sex"" id=""other"" value=""other""><br>
          <input type=""submit"" value=""Submit"">
        </form> 
    </body>
</html>"))
            {
                var browserWindow = BrowserWindow.Launch(webPage.FilePath);
                
                HtmlLabel label = browserWindow.Find<HtmlLabel>(By.Id("other"));

                //Assert
                Assert.AreEqual("other", label.LabelFor);

                browserWindow.Close();
            }
        }

        /// <summary>
        /// https://cuite.codeplex.com/discussions/440347
        /// </summary>
        [TestMethod]
        public void ClickAllControlsOnPage_UsingReflection_Succeeds()
        {
            //Arrange
            using (var webPage = new TempWebPage(
@"<html>
    <head>
        <title>test</title>
    </head>
    <body>
        <a href=""#"">test</a>
        <button>test</button>
<input type=""text"" value=""test""/>
    </body>
</html>"))
            {
                var browserWindow = BrowserWindow.Launch(webPage.FilePath);
                
                ControlBase a = browserWindow.Find<HtmlHyperlink>(By.SearchProperties("InnerText=test"));
                a.Click();

                List<Type> list = new List<Type>
                {
                    typeof(HtmlHyperlink),
                    typeof(HtmlButton),
                    typeof(HtmlEdit)
                };

                MethodInfo getMethodInfo = typeof(UITestControlExtensions).GetMethod("Find", BindingFlags.Public | BindingFlags.Static);

                foreach(Type t in list)
                {
                    MethodInfo test = getMethodInfo.MakeGenericMethod(t);
                    
                    ControlBase control;

                    if ((t == typeof(HtmlEdit)) || (t == typeof(HtmlTextArea)))
                    {
                        control = (ControlBase)test.Invoke(null, new object[] { browserWindow, By.ValueAttribute("test") });
                    }
                    else
                    {
                        //window.Find<t>("InnerText=test");
                        control = (ControlBase)test.Invoke(null, new object[] { browserWindow, By.SearchProperties("InnerText=test") });
                    }

                    //Act
                    control.Click();

                    if (control is HtmlEdit)
                    {
                        (control as HtmlEdit).Text = "text";
                    }
                    else if (control is HtmlTextArea)
                    {
                        (control as HtmlTextArea).Text = "text";
                    }
                }

                browserWindow.Close();
            }
        }

        /// <summary>
        /// https://cuite.codeplex.com/discussions/440720
        /// </summary>
        [TestMethod]
        public void SetText_UsingScreenObjects_Succeeds()
        {
            //Arrange
            using (var webPage = new TempWebPage(
@"<html>
    <head>
        <title>test</title>
    </head>
    <body>
        <div id=""div1"" >
            <div id=""div2"" >
                <input type=""text"" id=""edit""/>
            </div>
        </div>
    </body>
</html>"))
            {
                var page = Page.Launch<HtmlTestPage>(webPage.FilePath);

                //Act
                page.Div1.Div2.Edit.Text = "test";

                //Assert
                Assert.IsTrue(page.Div1.Div2.Edit.Exists);
            }
        }

        /// <summary>
        /// https://cuite.codeplex.com/discussions/440922
        /// </summary>
        [TestMethod]
        public void GetChildren_UsingHyperlinks_CanFindHyperlinkByInnerText()
        {
            //Arrange
            using (var webPage = new TempWebPage(
@"<html>
    <head>
        <title>test</title>
    </head>
    <body>
        <div id=""div1"">
            <a href=""#"">A - B - C</a>
            <a href=""#"">A - F - E</a>
            <a href=""#"">A - D - E</a>
            <a href=""#"">Z - B - C</a>
            <a href=""#"">Z - D - E</a>
        </div>
    </body>
</html>"))
            {
                var browserWindow = BrowserWindow.Launch(webPage.FilePath);
                
                //Act
                IEnumerable<ControlBase> collection = browserWindow.Find<HtmlDiv>(By.Id("div1")).GetChildren();
                foreach (ControlBase control in collection)
                {
                    if (control is HtmlHyperlink)
                    {
                        HtmlHyperlink link = (HtmlHyperlink)control;
                        if (link.InnerText.StartsWith("A"))
                        {
                            Trace.WriteLine(string.Format("found: {0}", link.InnerText));
                        }
                    }
                }

                browserWindow.Close();
            }
        }

        /// <summary>
        /// https://cuite.codeplex.com/discussions/440742
        /// </summary>
        [TestMethod]
        public void Launch_UsingNewInstanceOfABrowserWindow_CanUsePartialWindowTitle()
        {
            //Arrange
            using (var webPage = new TempWebPage(
@"<html>
    <head>
        <title>test 1 2 3</title>
    </head>
    <body>
        <button id=""buttonId"" >Button</button>
    </body>
</html>"))
            {
                var browserWindow = BrowserWindow.Launch(webPage.FilePath);
                
                //Act
                HtmlButton button = browserWindow.Find<HtmlButton>(By.Id("buttonId"));

                //Assert
                Assert.AreEqual(button.InnerText, "Button");

                Trace.WriteLine(browserWindow.Uri.ToString());

                browserWindow.Close();
            }
        }

        /// <summary>
        /// https://cuite.codeplex.com/discussions/442631
        /// </summary>
        [TestMethod]
        public void Launch_PageObjects_CanFindUnorderedListsByTagAndClassName()
        {
            // Arrange
            using (var webPage = new TempWebPage(
@"<html>
    <head>
        <title>test</title>
    </head>
    <body>
        <div id=""feed_tabs"" class=""ui-tabs"">
            <ul class=""dataFeedTab ui-tabs-nav"">
                <li data-bind-iterate=""."" class=""ui-tabs-selected ui-state-active"">
                    <a href=""#ui-tabs-1"" data-bind=""createTabLink"" data-bind-type=""function"" class=""JQtab"">Attack Correlation Details</a>
                </li>
                <li data-bind-iterate="""" iterate-limit="""" class="""">
                    <a href=""#ui-tabs-2"" data-bind=""createTabLink"" data-bind-type=""function"" class=""JQtab"">Common Details</a>
                </li>
                <li data-bind-iterate="""" iterate-limit="" class="">
                    <a href=""#ui-tabs-3"" data-bind=""createTabLink"" data-bind-type=""function"" class=""JQtab"">Exposure Details</a>
                </li>
                <li data-bind-iterate="""" iterate-limit="""" class=""""><a href=""#ui-tabs-4"" data-bind=""createTabLink"" data-bind-type=""function"" class=""JQtab"">IP Reputation Feed</a>
                </li>
            </ul>
          </div>
    </body>
</html>"))
            {
                // Act
                var page = Page.Launch<HtmlTestPageFeeds>(webPage.FilePath);

                var cus = new CUITControls.HtmlCustom(page.DivFeedTabs.SourceControl);
                cus.SearchProperties.Add(CUITControls.HtmlControl.PropertyNames.TagName, "ul", PropertyExpressionOperator.EqualTo);
                cus.SearchProperties.Add(CUITControls.HtmlControl.PropertyNames.Class, "dataFeedTab ui-tabs-nav", PropertyExpressionOperator.EqualTo);

                Assert.IsTrue(cus.Exists);
                Assert.IsTrue(page.CustomDataFeedTabsNav.Exists);

                // Assert
                Assert.IsTrue(page.CustomDataFeedTabsNav.Exists);
                Assert.IsTrue(page.CustomDataFeedTabsNav1.Exists);
                Assert.IsTrue(page.CustomDataFeedTabsNav2.Exists);
            }
        }

        /// <summary>
        /// https://cuite.codeplex.com/discussions/443094
        /// </summary>
        [TestMethod]
        public void Launch_TempHtmlFile_CanFindHyperlinkByHref()
        {
            // Arrange
            using (var webPage = new TempWebPage(
@"<html>
    <head>
        <title>test</title>
    </head>
    <body>
        <div class=""login"" style=""border: none;"">
        <div class=""member_box"">
            <span>APPLY FOR MEMBERSHIP</span> <a href=""/registration""> </a>
        </div>
    </body>
</html>"))
            {
                // Act
                var browserWindow = BrowserWindow.Launch(webPage.FilePath);
                
                // Assert
                HtmlHyperlink SignUpHyperLink = browserWindow.Find<HtmlHyperlink>(By.SearchProperties("href~registration"));
                Assert.IsTrue(SignUpHyperLink.Exists, "SignUp not found");
                
                browserWindow.Close();
            }
        }

        /// <summary>
        /// https://cuite.codeplex.com/discussions/443146
        /// </summary>
        [TestMethod]
        public void Launch_TempHtmlFileWithInputWithMaxLength_CanSetTextWhichExceedsMaxLength()
        {
            // Arrange
            using (var webPage = new TempWebPage(
@"<html>
    <head>
        <title>test</title>
    </head>
    <body>
        <input id=""input"" type=""text"" maxlength=10 />
    </body>
</html>"))
            {
                var browserWindow = BrowserWindow.Launch(webPage.FilePath);
                
                HtmlEdit input = browserWindow.Find<HtmlEdit>(By.Id("input"));

                // Act
                string inputText = "12345678901";
                string outputText = "1234567890";
                Keyboard.SendKeys(input.SourceControl, inputText);

                // Assert
                Assert.AreEqual(input.Text, outputText);

                browserWindow.Close();
            }
        }

        /// <summary>
        /// https://cuite.codeplex.com/discussions/439644
        /// </summary>
        [TestMethod]
        public void GetHtmlDiv_ByClass_Succeeds()
        {
            // Arrange
            using (var webPage = new TempWebPage(
@"<html>
    <head>
        <title>test</title>
    </head>
    <body>
        <div class=""button""><a href=""/main"">main text</a></div>
        <div class=""button""><a href=""/about"">about text</a></div>
    </body>
</html>"))
            {
                var browserWindow = BrowserWindow.Launch(webPage.FilePath);
                
                // Act
                HtmlDiv div = browserWindow.Find<HtmlDiv>(By.Class("button"));

                HtmlHyperlink about = browserWindow.Find<HtmlHyperlink>(By.SearchProperties("InnerText=about text;href~about"));
                HtmlDiv div2 = about.Parent as HtmlDiv;

                // Assert
                Assert.IsTrue(div.Exists);
                Assert.AreEqual("main text", div.SourceControl.InnerText);

                Assert.IsTrue(about.Exists);

                Assert.IsTrue(div2.Exists);
                Assert.AreEqual("about text", div2.SourceControl.InnerText);

                browserWindow.Close();
            }
        }

        /// <summary>
        /// https://cuite.codeplex.com/discussions/443509
        /// </summary>
        [TestMethod]
        public void GetHtmlRow_ById_Succeeds()
        {
            // Arrange
            using (var webPage = new TempWebPage(
@"<html>
    <head>
        <title>test</title>
    </head>
    <body>
        <table class=""cart"" cellspacing=""0"">
          <tbody>
            <tr id=""555002_gp2"">
                <td>
                    banana
                </td>
            </tr>
          </tbody>
        </table>
    </body>
</html>"))
            {
                var browserWindow = BrowserWindow.Launch(webPage.FilePath);
                
                // Act
                HtmlRow row = browserWindow.Find<HtmlRow>(By.Id("555002_gp2"));

                // Assert
                Assert.IsTrue(row.Exists);

                browserWindow.Close();
            }
        }

        /// <summary>
        /// Asserts that the enabled property of a disabled HTML input button returns false.
        /// </summary>
        [TestMethod]
        public void Enabled_OnDisabledHtmlInputButton_ReturnsFalse()
        {
            // Arrange
            using (var webPage = new TempWebPage(
@"<html>
    <head>
        <title>test</title>
    </head>
    <body>
        <input name=""inputName"" type=""submit"" value=""Click here"" disabled=""disabled"" />
    </body>
</html>"))
            {
                var browserWindow = BrowserWindow.Launch(webPage.FilePath);
                
                HtmlInputButton button = browserWindow.Find<HtmlInputButton>(By.ValueAttribute("Click here"));

                // Act and Assert
                Assert.IsFalse(button.Enabled);

                browserWindow.Close();
            }
        }

        /// <summary>
        /// Finds an HTML span element using multiple values of the class attribute.
        /// </summary>
        [TestMethod]
        public void Get_UsingMultipleValuesOfClassAttributeWithContainsOperatorOfHtmlSpan_ReturnsTheSpecificElementWithAllSpecifiedClassValues()
        {
            // Arrange
            using (var webPage = new TempWebPage(
@"<html>
    <head>
        <title>test</title>
    </head>
    <body>
        <span name=""span1"" class=""class1"" />
        <span name=""span2"" class=""class1 class4"" />
        <span name=""span3"" class=""class1 class2 class3"" />
    </body>
</html>"))
            {
                var browserWindow = BrowserWindow.Launch(webPage.FilePath);
                
                HtmlSpan span3 = browserWindow.Find<HtmlSpan>(By
                    .ClassContains("class1")
                    .AndClassContains("class2"));

                // Act and Assert
                Assert.AreEqual("span3", span3.SourceControl.Name);

                browserWindow.Close();
            }
        }

        /// <summary>
        /// Gets the selected value of a radio button.
        /// </summary>
        [TestMethod]
        public void GetSelectedValue_OfRadioButton_Succeeds()
        {
            // Arrange
            using (var webPage = new TempWebPage(
@"<html>
    <head>
        <title>test</title>
    </head>
    <body>
        <input type=""radio"" name=""radio:tab1:gender.type.male"" value=""male"" checked=checked>Male</input><br/>
        <input type=""radio"" name=""radio:tab1:gender.type.female"" value=""female"">Female</input><br/>
        <input type=""radio"" name=""radio:tab1:gender.type.other"" value=""other"">Other</input><br/>
    </body>
</html>"))
            {
                var browserWindow = BrowserWindow.Launch(webPage.FilePath);
                
                // Act
                HtmlRadioButton genderTypeMale = browserWindow.Find<HtmlRadioButton>(By.Name("radio:tab1:gender.type.male"));

                // Assert
                Assert.IsTrue(genderTypeMale.Selected);
                Assert.AreEqual("male", genderTypeMale.ValueAttribute);

                browserWindow.Close();
            }
        }

        /// <summary>
        /// Sets the text on an HTML password field.
        /// </summary>
        [TestMethod]
        public void SetText_OnHtmlPassword_Succeeds()
        {
            // Arrange
            using (var webPage = new TempWebPage(
@"<html>
    <head>
        <title>test</title>
    </head>
    <body>
        <div class=""row textbox"" id=""idDiv_PWD_PasswordTb"">
            <div style=""width: 100%; position: relative;"">
                <input name=""passwd"" id=""i0118"" aria-labelledby=""idDiv_PWD_PasswordExample"" type=""password"" autocomplete=""off"">
                    <div class=""phholder"" style=""left: 0px; top: 0px; width: 100%; position: absolute; z-index: 5;"">
                        <div class=""placeholder"" id=""idDiv_PWD_PasswordExample"" aria-hidden=""true"" style=""cursor: text;"">Password</div>
                    </div>
            </div>
        </div>
    </body>
</html>"))
            {
                var browserWindow = BrowserWindow.Launch(webPage.FilePath);
                
                HtmlPassword txtPwd = browserWindow.Find<HtmlPassword>(By.Id("i0118"));

                // Act
                txtPwd.Text = "hello";

                // TODO: Assert
                browserWindow.Close();
            }
        }

        /// <summary>
        /// https://cuite.codeplex.com/discussions/522298
        /// </summary>
        [TestMethod]
        public void Click_OnHtmlHyperlink_InTableWithEmptyCell_Succeeds()
        {
            // Arrange
            using (var webPage = new TempWebPage(
@"<html>
    <head>
        <title>test</title>
    </head>
    <body>
        <table id=""tableId"">
            <tr id=""row"">
                <td></td>
                <td><a href=""#"">Details</a></td>
            </tr>
        </table>
    </body>
</html>"))
            {
                var browserWindow = BrowserWindow.Launch(webPage.FilePath);
                var table = browserWindow.Find<HtmlTable>(By.Id("tableId"));

                HtmlCell cell = table.GetCell(0, 1);
                HtmlHyperlink hyperlink = cell.Find<HtmlHyperlink>();

                // Act
                hyperlink.Click();

                // TODO: Assert
                browserWindow.Close();
            }
        }

        /// <summary>
        /// https://github.com/icnocop/cuite/issues/92
        /// </summary>
        [TestMethod]
        public void GetChildrenOfSameType()
        {
            // Arrange
            using (var webPage = new TempWebPage(
                @"<html>
                    <head>
                        <title>test</title>
                    </head>
                    <body>
                        <div id=""panel"">
                            <p>1</p>
                            <p>2</p>
                            <p>3</p>
                        </div>
                    </body>
                </html>"))
            {
                var browserWindow = BrowserWindow.Launch(webPage.FilePath);
                var panel = browserWindow.Find<HtmlDiv>(By.Id("panel"));

                // Act
                ControlBase[] children = panel.GetChildren().ToArray();

                // Assert
                Assert.AreEqual(3, children.Length);
                
                Assert.IsInstanceOfType(children[0], typeof(HtmlParagraph));
                Assert.AreEqual("1", ((HtmlParagraph)children[0]).InnerText);

                Assert.IsInstanceOfType(children[1], typeof(HtmlParagraph));
                Assert.AreEqual("2", ((HtmlParagraph)children[1]).InnerText);

                Assert.IsInstanceOfType(children[2], typeof(HtmlParagraph));
                Assert.AreEqual("3", ((HtmlParagraph)children[2]).InnerText);
                
                browserWindow.Close();
            }
        }

        /// <summary>
        /// https://github.com/icnocop/cuite/issues/92
        /// </summary>
        [TestMethod]
        public void GetChildrenOfMixedType()
        {
            // Arrange
            using (var webPage = new TempWebPage(
                @"<html>
                    <head>
                        <title>test</title>
                    </head>
                    <body>
                        <div id=""panel"">
                            <p>1</p>
                            <h1>2</h1>
                            <p>3</p>
                        </div>
                    </body>
                </html>"))
            {
                var browserWindow = BrowserWindow.Launch(webPage.FilePath);
                var panel = browserWindow.Find<HtmlDiv>(By.Id("panel"));

                // Act
                ControlBase[] children = panel.GetChildren().ToArray();

                // Assert
                Assert.AreEqual(3, children.Length);

                Assert.IsInstanceOfType(children[0], typeof(HtmlParagraph));
                Assert.AreEqual("1", ((HtmlParagraph)children[0]).InnerText);

                Assert.IsInstanceOfType(children[1], typeof(HtmlHeading1));
                Assert.AreEqual("2", ((HtmlHeading1)children[1]).InnerText);

                Assert.IsInstanceOfType(children[2], typeof(HtmlParagraph));
                Assert.AreEqual("3", ((HtmlParagraph)children[2]).InnerText);

                browserWindow.Close();
            }
        }
    }
}