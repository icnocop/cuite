﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using CUITe;
using CUITe.Browsers;
using CUITe.Controls;
using CUITe.Controls.HtmlControls;
using CUITe.Controls.WinControls;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sut.HtmlTest.ObjectRepository;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace Sut.HtmlTest
{
    [CodedUITest]
    [DeploymentItem("XMLFile1.xml")]
    [DeploymentItem("XMLFile2.xml")]
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

        [Ignore] //TODO: use known html
        [TestMethod]
        public void HtmlEdit_SetText_Succeeds()
        {
            GoogleHomePage pgGHomePage = BrowserWindowUnderTest.Launch<GoogleHomePage>("http://www.google.com");
            pgGHomePage.txtSearch.Text = "Coded UI Test Framework";
            GoogleSearch pgSearch = BrowserWindowUnderTest.GetBrowserWindow<GoogleSearch>();
// ReSharper disable once UnusedVariable
            UITestControlCollection col = pgSearch.divSearchResults.SourceControl.GetChildren();
            //do something with collection
            pgSearch.Close();
        }

        [TestMethod]
        public void DataManager_GetDataRowUsingEmbeddedResourceFromTypeAsString_Succeeds()
        {
            AssertGetDataRowHashtableFromEmbeddedResourceExpectedValues(Type.GetType("Sut.HtmlTest.HtmlControlTests"));
        }

        [TestMethod]
        public void DataManager_GetDataRowUsingEmbeddedResource_Succeeds()
        {
            AssertGetDataRowHashtableFromEmbeddedResourceExpectedValues(typeof(HtmlControlTests));
        }

        private void AssertGetDataRowHashtableFromEmbeddedResourceExpectedValues(Type type)
        {
            Hashtable ht = DataManager.GetDataRow(type, "XMLFile1.xml", "tc2");
            Assert.AreEqual("test", ht["test"]);
            Assert.AreEqual("Kondapur, Hyderabad", ht["address"]);
            Assert.AreEqual("Suresh", ht["firstname"]);
            Assert.AreEqual("Balasubramanian", ht["lastname"]);
            Assert.AreEqual("04/19/1973", ht["dob"]);
            Assert.AreEqual("37", ht["age"]);
            Assert.AreEqual("Indian", ht["nationality"]);
        }

        //[TestMethod]
        //public void DataManager_GetDataRowUsingFile_Succeeds()
        //{
        //    Hashtable ht = CUITe.DataManager.GetDataRow("XMLFile2.xml", "content2");
        //    Assert.AreEqual("SomeTest", ht["test"]);
        //    Assert.AreEqual("Somewhere, Somewhere", ht["address"]);
        //    Assert.AreEqual("SomeFirstName", ht["firstname"]);
        //    Assert.AreEqual("SomeLastNameBigger", ht["lastname"]);
        //    Assert.AreEqual("01/01/1900", ht["dob"]);
        //    Assert.AreEqual("101", ht["age"]);
        //    Assert.AreEqual("USA", ht["nationality"]);
        //}

        [TestMethod]
        [Ignore] // this test currently fails
        public void SelectItemByText_OnTelerikASPNETComboBox_Succeeds()
        {
            DemosOfTeleriksASPNETComboBoxControl pgPage = BrowserWindowUnderTest.Launch<DemosOfTeleriksASPNETComboBoxControl>(
                "http://demos.telerik.com/aspnet-ajax/combobox/examples/default/defaultcs.aspx");
            pgPage.cbProduct.SelectItemByText("Tofu", 5000);
            pgPage.cbRegion.SelectItemByText("Bloomfield Hills", 5000);
            pgPage.cbDealer.SelectItemByText("Exotic Liquids", 5000);
            pgPage.cbPaymentMethod.SelectItemByText("American Express", 5000);
            pgPage.Close();
        }

        [TestMethod]
        public void SetText_OnTelerikASPNETComboBox_SelectsItemByText()
        {
            DemosOfTeleriksASPNETComboBoxControl window = BrowserWindowUnderTest.Launch<DemosOfTeleriksASPNETComboBoxControl>(
                "http://demos.telerik.com/aspnet-ajax/combobox/examples/default/defaultcs.aspx");
            window.Product.Text = "Tofu";
            Keyboard.SendKeys("{Tab}"); // close drop down menu
            window.Region.Text = "Bloomfield Hills";
            Keyboard.SendKeys("{Tab}"); // close drop down menu
            window.Dealer.Text = "Exotic Liquids";
            Keyboard.SendKeys("{Tab}"); // close drop down menu
            window.PaymentMethod.Click(); // America Express
            Keyboard.SendKeys("{Down}"); // MasterCard
            Keyboard.SendKeys("{Down}"); // Visa
            Keyboard.SendKeys("{Tab}"); // close drop down menu
            window.Close();
        }

        [TestMethod]
        [WorkItem(588)]
        public void HtmlControl_WithInvalidSearchProperties_ThrowsInvalidSearchPropertyNamesException()
        {
            //TODO: use known html
            try
            {
                BrowserWindowUnderTest.Launch<GoogleHomePageWithInvalidControlSearchProperties>("http://www.google.com");

                Assert.Fail("InvalidSearchPropertyNamesException not thrown");
            }
            catch (TargetInvocationException ex)
            {
                Console.WriteLine(ex.ToString());

                Assert.AreEqual(typeof(InvalidSearchPropertyNamesException), ex.InnerException.GetType());
            }
        }

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

                using (TempFile tempFile = new TempFile(
@"<html>
    <head>
        <title>test</title>
    </head>
    <body>
    </body>
</html>"))
                {
                    BrowserWindow.Launch(tempFile.FilePath);
                    var window = new BrowserWindowUnderTest("test");

                    //Act
                    HtmlDiv div = window.Find<HtmlDiv>(By.Id("invalid"));

                    //Assert
                    Assert.IsFalse(div.Exists);

                    window.Close();
                }
            }
            finally
            {
                //reset default setting
                Playback.PlaybackSettings.SmartMatchOptions = smartMatchOptions;
            }
        }

        [TestMethod]
        public void HtmlTable_GetColumnHeaders_Succeeds()
        {
            BrowserWindow.Launch(currentDirectory + "/TestHtmlPage.html");
            var bWin = new BrowserWindowUnderTest("A Test");
            var tbl = bWin.Find<HtmlTable>(By.Id("calcWithHeaders"));
            string[] saExpectedValues = { "Header1", "Header2", "Header3" };
            string[] saHeaders = tbl.GetColumnHeaders();
            Assert.AreEqual(saExpectedValues[0], saHeaders[0]);
            Assert.AreEqual(saExpectedValues[1], saHeaders[1]);
            Assert.AreEqual(saExpectedValues[2], saHeaders[2]);
            bWin.Close();
        }

        [TestMethod]
        public void HtmlTable_FindHeaderAndClick_Succeeds()
        {
            //Arrange
            using (TempFile tempFile = new TempFile(
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

                BrowserWindow.Launch(tempFile.FilePath);
                var window = new BrowserWindowUnderTest("test");

                var table = window.Find<HtmlTable>(By.Id("tableId"));

                //Act
                table.FindHeaderCellAndClick(0, 2);

                window.Close();
            }
        }

        [TestMethod]
        public void HtmlTable_ColumnCount_Succeeds()
        {
            BrowserWindow.Launch(currentDirectory + "/TestHtmlPage.html");
            var bWin = new BrowserWindowUnderTest("A Test");
            var tbl = bWin.Find<HtmlTable>(By.Id("calcWithHeaders"));
            Assert.AreEqual(3, tbl.ColumnCount);
            bWin.Close();
        }

        [TestMethod]
        public void HtmlTable_ClickOnColumnHeader_Succeeds()
        {
            BrowserWindow.Launch(currentDirectory + "/TestHtmlPage.html");
            var bWin = new BrowserWindowUnderTest("A Test");
            var tbl = bWin.Find<HtmlTable>(By.Id("tableWithAlertOnHeaderClick"));
            tbl.FindHeaderCellAndClick(0, 0);
            bWin.PerformDialogAction(BrowserDialogAction.Ok);
            bWin.Close();
        }

        [TestMethod]
        [WorkItem(638)]
        public void HtmlTable_FindRowUsingTableWithRowHeaders_Succeeds()
        {
            var bWin = BrowserWindowUnderTest.Launch(currentDirectory + "/TestHtmlPage.html");
            var tbl = bWin.Find<HtmlTable>(By.Id("calcWithHeaders"));
            tbl.FindRowAndClick("9", 2, HtmlTableSearchOptions.NormalTight);
            Assert.AreEqual("9", tbl.GetCellValue(3, 2).Trim());
            bWin.Close();
        }

        [TestMethod]
        [WorkItem(638)]
        public void HtmlTable_FindRowUsingTableWithoutRowHeaders_Succeeds()
        {
            var bWin = BrowserWindowUnderTest.Launch(currentDirectory + "/TestHtmlPage.html");
            var tbl = bWin.Find<HtmlTable>(By.Id("calcWithOutHeaders"));
            tbl.FindRowAndClick("9", 2, HtmlTableSearchOptions.NormalTight);
            Assert.AreEqual("9", tbl.GetCellValue(2, 2).Trim());
            bWin.Close();
        }

        [TestMethod]
        public void HtmlTable_GetCellValueWithHeaderCell_Succeeds()
        {
            var bWin = BrowserWindowUnderTest.Launch(currentDirectory + "/TestHtmlPage.html");

            var termTable = bWin.Find<HtmlTable>(By.Id("calcWithHeaderCells"));

            Assert.AreEqual("3", termTable.GetCellValue(1, 1));

            bWin.Close();
        }

        [TestMethod]
        public void HtmlTable_GetCellValueUsingTableWithTHInTBODY_Succeeds()
        {
            //Arrange
            using (TempFile tempFile = new TempFile(
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
                BrowserWindow.Launch(tempFile.FilePath);
                var window = new BrowserWindowUnderTest("test");

                var table = window.Find<HtmlTable>(By.Id("tableId"));

                //Act
                table.FindRowAndClick("LUN_04", 0, HtmlTableSearchOptions.NormalTight);

                //Assert
                Assert.AreEqual("LUN_04", table.GetCellValue(1, 0).Trim());

                window.Close();
            }
        }

        [TestMethod]
        public void HtmlInputButton_UsingSearchPropertyWithValueAsKey_Succeeds()
        {
            //Internet Explorer may display the message: Internet Explorer restricted this webpage from running scripts or ActiveX controls.
            //This security restriction prevents the alert message to appear.
            //To enable running scripts on the local computer, go to Tools > Internet options > Advanced > Security > [checkmark] Allow active content to run in files on My Computer

            //Arrange
            using (TempFile tempFile = new TempFile(
@"<html>
    <head>
        <title>test</title>
    </head>
    <body>
        <input type=""submit"" value=""Log In"" onclick=""alert('onclick');""/>
    </body>
</html>"))
            {
                BrowserWindow.Launch(tempFile.FilePath);
                var window = new BrowserWindowUnderTest("test");

                HtmlInputButton button = window.Find<HtmlInputButton>(By.ValueAttribute("Log In"));

                //Act
                button.Click();

                if (BrowserWindowUnderTest.GetCurrentBrowser() is InternetExplorer)
                {
                    //read JavaScript alert text
                    WinWindow popup = new WinWindow(By.Name("Message from webpage").AndSearchProperties("ClassName=#32770"));
                    WinText text = popup.Find<WinText>();
                    Assert.AreEqual("onclick", text.DisplayText);
                }

                window.PerformDialogAction(BrowserDialogAction.Ok);

                window.Close();
            }
        }

        [TestMethod]
        public void PointAndClick_OnHtmlInputButton_Succeeds()
        {
            //Arrange
            using (TempFile tempFile = new TempFile(
@"<html>
    <head>
        <title>test</title>
    </head>
    <body>
        <input type=""submit"" value=""Log In"" onclick=""alert('onclick');""/>
    </body>
</html>"))
            {
                BrowserWindow.Launch(tempFile.FilePath);
                var window = new BrowserWindowUnderTest("test");

                HtmlInputButton button = window.Find<HtmlInputButton>(By.ValueAttribute("Log In"));

                //Act
                button.PointAndClick();

                window.PerformDialogAction(BrowserDialogAction.Ok);

                window.Close();
            }
        }

        [TestMethod]
        public void HtmlFileInput_SetFile_Succeeds()
        {
            //Arrange
            using (TempFile tempFile = new TempFile(
@"<html>
    <head>
        <title>test</title>
    </head>
    <body>
        <input name=""inputName"" type=""file"" id=""inputId"" />
    </body>
</html>"))
            {
                BrowserWindow.Launch(tempFile.FilePath);
                var window = new BrowserWindowUnderTest("test");

                HtmlFileInput fileInput = window.Find<HtmlFileInput>(By.Id("inputId"));

                string tempInputFilePath = Path.GetTempFileName();

                //Act
                fileInput.FileName = tempInputFilePath;

                window.Close();

                File.Delete(tempInputFilePath);
            }
        }

        [TestMethod]
        [Ignore]
        public void HtmlHyperlink_OnSharePoint2010_Succeeds()
        {
            BrowserWindow.Launch("http://myasia/sites/sureba/Default.aspx");
            BrowserWindowUnderTest.Authenticate("username", "passwd");
            var bWin = new BrowserWindowUnderTest("Suresh Balasubramanian");
            bWin.Find<HtmlHyperlink>(By.Id("idHomePageNewDocument")).Click();
            var closeLink = bWin.Find<HtmlHyperlink>(By.SearchProperties("Title=Close;class=ms-dlgCloseBtn"));
            //clicking closeLink directly doesn't work as the maximizeLink is clicked due to the controls being placed too close to each other
            Mouse.Click(closeLink.SourceControl.GetChildren()[0].GetChildren()[0]); 
            bWin.RunScript(@"STSNavigate2(event,'/sites/sureba/_layouts/SignOut.aspx');");
        }

        [TestMethod]
        public void HtmlControl_GetChildren_Succeeds()
        {
            var bWin = BrowserWindowUnderTest.Launch(currentDirectory + "/TestHtmlPage.html");
            var div = bWin.Find<HtmlDiv>(By.Id("calculatorContainer1"));
            var col = div.GetChildren();
            Assert.IsTrue(col.ElementAt(0).SourceControlType.Name == "HtmlDiv");
            Assert.IsTrue(col.ElementAt(1).SourceControlType.Name == "HtmlTable");
            Assert.IsTrue(((HtmlDiv)col.ElementAt(0)).InnerText == "calcWithHeaders");
            var tbl = (HtmlTable)col.ElementAt(1);
            Assert.AreEqual("6", tbl.GetCellValue(2, 2).Trim());
            bWin.Close();
        }

        [TestMethod]
        public void HtmlParagraph_InnertText_Succeeds()
        {
            var bWin = BrowserWindowUnderTest.Launch(currentDirectory + "/TestHtmlPage.html");
            Assert.IsTrue(bWin.Find<HtmlParagraph>(By.Id("para1")).InnerText.Contains("HtmlParagraph"));
            bWin.Close();
        }

        [TestMethod]
        public void HtmlComboBox_Items_Succeeds()
        {
            //Arrange
            using (TempFile tempFile = new TempFile(
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
                BrowserWindow.Launch(tempFile.FilePath);
                var window = new BrowserWindowUnderTest("test");

                //Act
                HtmlComboBox comboBox = window.Find<HtmlComboBox>(By.Id("selectId"));

                //Assert
                Assert.AreEqual("Football", comboBox.Items[1]);
                Assert.IsTrue(comboBox.Items.Contains("Cricket"));

                window.Close();
            }
        }

        [TestMethod]
        public void SelectItem_ByIndexOnHtmlComboBox_Succeeds()
        {
            //Arrange
            using (TempFile tempFile = new TempFile(
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
                BrowserWindow.Launch(tempFile.FilePath);
                var window = new BrowserWindowUnderTest("test");

                //Act
                HtmlComboBox comboBox = window.Find<HtmlComboBox>(By.Id("selectId"));

                comboBox.SelectIndex(1);

                //Assert
                Assert.AreEqual("Football", comboBox.SelectedItem);

                window.Close();
            }
        }

        [TestMethod]
        public void HtmlParagraph_InObjectRepository_Succeeds()
        {
            var testpage = BrowserWindowUnderTest.Launch<TestHtmlPage>(currentDirectory + "/TestHtmlPage.html");
            string content = testpage.p.InnerText;
            Assert.IsTrue(content.Contains("HtmlParagraph"));
            testpage.Close();
        }

        [TestMethod]
        public void HtmlParagraph_TraverseSiblingsParentAndChildren_Succeeds()
        {
            var bWin = BrowserWindowUnderTest.Launch(currentDirectory + "/TestHtmlPage.html");
            var p = bWin.Find<HtmlParagraph>(By.Id("para1"));
            Assert.IsTrue(((HtmlEdit)p.PreviousSibling).SourceControl.Name == "text1_test");
            Assert.IsTrue(((HtmlInputButton)p.NextSibling).ValueAttribute == "sample button");
            Assert.IsTrue(((HtmlDiv)p.Parent).SourceControl.Id == "parentdiv");
            Assert.IsTrue(((HtmlPassword)p.Parent.FirstChild).SourceControl.Name == "pass");
            bWin.Close();
        }

        [TestMethod]
        [DeploymentItem("iframe_test.html")]
        [DeploymentItem("iframe.html")]
        public void HtmlInputButton_ClickInIFrame_Succeeds()
        {
            var bWin = BrowserWindowUnderTest.Launch(currentDirectory + "/iframe_test.html");
            bWin.Find<HtmlInputButton>(By.ValueAttribute("Log In")).Click();
            bWin.Close();
        }

        [TestMethod]
        [DeploymentItem("iframe_test.html")]
        [DeploymentItem("iframe.html")]
        public void HtmlInputButton_ClickInCUITeIFrame_Succeeds()
        {
            var bWin = BrowserWindowUnderTest.Launch(currentDirectory + "/iframe_test.html");
            HtmlIFrame iFrame = bWin.Find<HtmlIFrame>();
            iFrame.Find<HtmlInputButton>(By.ValueAttribute("Log In")).Click();
            bWin.Close();
        }

        [TestMethod]
        [WorkItem(882)]
        public void HtmlInputButton_GetWithValueContainingWhitespace_Succeeds()
        {
            //Arrange
            using (TempFile tempFile = new TempFile(
@"<html>
    <head>
        <title>test</title>
    </head>
    <body>
        <input name=""inputName"" type=""submit"" value=""   Search   "" />
    </body>
</html>"))
            {
                BrowserWindow.Launch(tempFile.FilePath);
                var window = new BrowserWindowUnderTest("test");

                HtmlInputButton button = window.Find<HtmlInputButton>(By.ValueAttribute("   Search   "));

                //Act
                button.Click();

                window.Close();
            }
        }

        [TestMethod]
        [Ignore] // this test currently fails
        public void HtmlButton_HiddenByStyle_ControlExistsAndCanAssertOnStyle()
        {
            //Arrange
            using (TempFile tempFile = new TempFile(
@"<html>
    <head>
        <title>test</title>
    </head>
    <body>
        <button id=""buttonId"" style=""display: none;"" >Hidden</button>
    </body>
</html>"))
            {
                BrowserWindow.Launch(tempFile.FilePath);
                var window = new BrowserWindowUnderTest("test");

                //Act
                HtmlButton button = window.Find<HtmlButton>(By.Id("buttonId"));

                //Assert
                Assert.IsTrue(button.Exists);

                Assert.IsTrue(button.SourceControl.ControlDefinition.Contains("style=\"display: none;\""));

                window.Close();
            }
        }

        [TestMethod]
        public void HtmlUnorderedList_WithListItems_CanAssertOnListItems()
        {
            // Arrange
            var window = BrowserWindowUnderTest.Launch(currentDirectory + "/TestHtmlPage.html");
            var list = window.Find<HtmlUnorderedList>(By.Id("unorderedList"));

            // Act
            List<HtmlListItem> children = list.GetChildren()
                .Cast<HtmlListItem>()
                .ToList();

            // Assert
            Assert.AreEqual(3, children.Count());
            Assert.AreEqual("List Item 1", children.ElementAt(0).InnerText);
            Assert.AreEqual("List Item 2", children.ElementAt(1).InnerText);
            Assert.AreEqual("List Item 3", children.ElementAt(2).InnerText);
            
            window.Close();
        }

        [TestMethod]
        public void HtmlUnorderedListInObjectRepository_WithListItems_CanAssertOnListItems()
        {
            // Arrange
            var window = BrowserWindowUnderTest.Launch<TestHtmlPage>(currentDirectory + "/TestHtmlPage.html");

            // Act
            List<HtmlListItem> children = window.list.GetChildren()
                .Cast<HtmlListItem>()
                .ToList();

            // Assert
            Assert.AreEqual(3, children.Count());
            Assert.AreEqual("List Item 1", children.ElementAt(0).InnerText);
            Assert.AreEqual("List Item 2", children.ElementAt(1).InnerText);
            Assert.AreEqual("List Item 3", children.ElementAt(2).InnerText);

            window.Close();
        }

        [TestMethod]
        public void HtmlCheckBox_DisabledByStyle_ControlExistsAndCanGetCheckedState()
        {
            //Arrange
            using (TempFile tempFile = new TempFile(
@"<html>
    <head>
        <title>test</title>
    </head>
    <body>
        <input type=""checkbox"" id=""checkBoxId"" disabled=""disabled"" name=""checkBoxName"" checked=""checked"" />
    </body>
</html>"))
            {
                BrowserWindow.Launch(tempFile.FilePath);
                var window = new BrowserWindowUnderTest("test");

                //Act
                HtmlCheckBox checkBox = window.Find<HtmlCheckBox>(By.Id("checkBoxId"));

                //Assert
                Assert.IsTrue(checkBox.Exists);
                Assert.IsTrue(checkBox.Checked);

                window.Close();
            }
        }

        [TestMethod]
        public void SelectItem_UsingHtmlComboBoxThatAlertsOnChange_Succeeds()
        {
            //Arrange
            using (TempFile tempFile = new TempFile(
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
                var window = BrowserWindowUnderTest.Launch(tempFile.FilePath);

                HtmlComboBox comboBox = window.Find<HtmlComboBox>(By.Id("selectId"));

                comboBox.SetFocus();

                //Act
                // select item "Banana"
                Keyboard.SendKeys(comboBox.SourceControl, "{DOWN}");

                window.PerformDialogAction(BrowserDialogAction.Ok);

                window.Close();
            }
        }

        [TestMethod]
        public void SetText_OnHtmlEdit_Succeeds()
        {
            //Arrange
            using (TempFile tempFile = new TempFile(
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
                BrowserWindow.Launch(tempFile.FilePath);
                var window = new BrowserWindowUnderTest("test");
                HtmlDiv div = window.Find<HtmlDiv>(By.Id("div1"));
                HtmlEdit inputTextBox = div.Find<HtmlEdit>();

                //Act
                inputTextBox.Text = "text";

                //Assert
                Assert.AreEqual("text", inputTextBox.Text);

                window.Close();
            }
        }

        [TestMethod]
        [Ignore] // this test currently fails
        public void GetHtmlControl_OnHtml5Control_Succeeds()
        {
            // Arrange
            using (TempFile tempFile = new TempFile(
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
                var bWin = BrowserWindowUnderTest.Launch(tempFile.FilePath);

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

        [TestMethod]
        public void SelectedItems_OnHtmlList_Succeeds()
        {
            //Arrange
            using (TempFile tempFile = new TempFile(
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
                BrowserWindow.Launch(tempFile.FilePath);
                var bWin = new BrowserWindowUnderTest("test");
                HtmlList list = bWin.Find<HtmlList>(By.Id("selectId"));

                string[] itemsToSelect = { "1", "2" };

                //Act
                list.SelectedItems = itemsToSelect;

                //Assert
                CollectionAssert.AreEqual(itemsToSelect, list.SelectedItems);

                bWin.Close();
            }
        }

        [TestMethod]
        public void Click_OnHtmlInputButtonWithEqualsSignInSearchPropertyValue_Succeeds()
        {
            //Arrange
            using (TempFile tempFile = new TempFile(
@"<html>
    <head>
        <title>test</title>
    </head>
    <body>
        <input type=""submit"" value=""="" onclick=""alert('onclick');""/>
    </body>
</html>"))
            {
                BrowserWindow.Launch(tempFile.FilePath);
                var window = new BrowserWindowUnderTest("test");

                HtmlInputButton button = window.Find<HtmlInputButton>(By.ValueAttribute("="));

                //Act
                button.Click();

                window.PerformDialogAction(BrowserDialogAction.Ok);

                window.Close();
            }
        }

        [TestMethod]
        public void InnerText_OnHtmlComboBoxWithDisabledItems_Succeeds()
        {
            //Arrange
            using (TempFile tempFile = new TempFile(
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
                BrowserWindow.Launch(tempFile.FilePath);
                var window = new BrowserWindowUnderTest("test");

                HtmlComboBox comboBox = window.Find<HtmlComboBox>(By.Id("selectId"));
                
                //Assert
                Assert.AreEqual(3, comboBox.ItemCount);
                CollectionAssert.AreEqual(new[] { "1", "2", "3" }, comboBox.Items);
                Assert.AreEqual("1 2 3", comboBox.InnerText.Trim());

                window.Close();
            }
        }

        [TestMethod]
        public void LabelFor_OnHtmlLabel_Succeeds()
        {
            //Arrange
            using (TempFile tempFile = new TempFile(
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
                BrowserWindow.Launch(tempFile.FilePath);
                var window = new BrowserWindowUnderTest("test");

                HtmlLabel label = window.Find<HtmlLabel>(By.Id("other"));

                //Assert
                Assert.AreEqual("other", label.LabelFor);

                window.Close();
            }
        }

        /// <summary>
        /// https://cuite.codeplex.com/discussions/440347
        /// </summary>
        [TestMethod]
        public void ClickAllControlsOnPage_UsingReflection_Succeeds()
        {
            //Arrange
            using (TempFile tempFile = new TempFile(
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
                BrowserWindow.Launch(tempFile.FilePath);
                var window = new BrowserWindowUnderTest("test");

                ControlBase a = window.Find<HtmlHyperlink>(By.SearchProperties("InnerText=test"));
                a.Click();

                List<Type> list = new List<Type>();
                list.Add(typeof(HtmlHyperlink));
                list.Add(typeof(HtmlButton));
                list.Add(typeof(HtmlEdit));

                MethodInfo getMethodInfo = typeof(BrowserWindowUnderTest).GetMethod("Find", new[] { typeof(By) });

                foreach(Type t in list)
                {
                    MethodInfo test = getMethodInfo.MakeGenericMethod(t);
                    
                    ControlBase control;

                    if ((t == typeof(HtmlEdit)) || (t == typeof(HtmlTextArea)))
                    {
                        control = (ControlBase)test.Invoke(window, new object[] { By.ValueAttribute("test") });
                    }
                    else
                    {
                        //window.Find<t>("InnerText=test");
                        control = (ControlBase)test.Invoke(window, new object[] { By.SearchProperties("InnerText=test") });
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

                window.Close();
            }
        }

        /// <summary>
        /// https://cuite.codeplex.com/discussions/440720
        /// </summary>
        [TestMethod]
        public void SetText_UsingControlsDefinedInObjectRepositoryHierarchy_Succeeds()
        {
            //Arrange
            using (TempFile tempFile = new TempFile(
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
                var window = BrowserWindowUnderTest.Launch<HtmlTestPage>(tempFile.FilePath);

                //Act
                window.div1.div2.edit.Text = "test";

                //Assert
                Assert.IsTrue(window.div1.div2.edit.Exists);
                Assert.IsTrue(window.div1.div2.Exists);
                Assert.IsTrue(window.div1.Exists);

                window.Close();
            }
        }

        /// <summary>
        /// https://cuite.codeplex.com/discussions/440922
        /// </summary>
        [TestMethod]
        public void GetChildren_UsingHyperlinks_CanFindHyperlinkByInnerText()
        {
            //Arrange
            using (TempFile tempFile = new TempFile(
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
                BrowserWindow.Launch(tempFile.FilePath);
                var window = new BrowserWindowUnderTest("test");

                //Act
                IEnumerable<ControlBase> collection = window.Find<HtmlDiv>(By.Id("div1")).GetChildren();
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

                window.Close();
            }
        }

        /// <summary>
        /// https://cuite.codeplex.com/discussions/440742
        /// </summary>
        [TestMethod]
        public void Launch_UsingNewInstanceOfABrowserWindow_CanUsePartialWindowTitle()
        {
            //Arrange
            using (TempFile tempFile = new TempFile(
@"<html>
    <head>
        <title>test 1 2 3</title>
    </head>
    <body>
        <button id=""buttonId"" >Button</button>
    </body>
</html>"))
            {
                BrowserWindow.Launch(tempFile.FilePath);
                var window = new BrowserWindowUnderTest("test");

                //Act
                HtmlButton button = window.Find<HtmlButton>(By.Id("buttonId"));

                //Assert
                Assert.AreEqual(button.InnerText, "Button");

                Trace.WriteLine(window.Uri.ToString());

                window.Close();
            }
        }

        /// <summary>
        /// https://cuite.codeplex.com/discussions/442631
        /// </summary>
        [TestMethod]
        public void Launch_ObjectRepositoryTempHtmlFile_CanFindUnorderedListsByTagAndClassName()
        {
            // Arrange
            using (TempFile tempFile = new TempFile(
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
                HtmlTestPageFeeds window = BrowserWindowUnderTest.Launch<HtmlTestPageFeeds>(tempFile.FilePath);

                CUITControls.HtmlCustom cus = new CUITControls.HtmlCustom(window.divFeedTabs.SourceControl);
                cus.SearchProperties.Add(CUITControls.HtmlControl.PropertyNames.TagName, "ul", PropertyExpressionOperator.EqualTo);
                cus.SearchProperties.Add(CUITControls.HtmlControl.PropertyNames.Class, "dataFeedTab ui-tabs-nav", PropertyExpressionOperator.EqualTo);

                Assert.IsTrue(cus.Exists);

                HtmlCustom cusDataFeedTabsNav = window.Find<HtmlCustom>(By.TagName("ul").AndSearchProperties("Class=dataFeedTab ui-tabs-nav"));
                Assert.IsTrue(cusDataFeedTabsNav.Exists);

                // Assert
                Assert.IsTrue(window.cusDataFeedTabsNav.Exists);
                Assert.IsTrue(window.cusdatafeedtabsnav1.Exists);
                Assert.IsTrue(window.cusDataFeedTabsNav2.Exists);
                
                window.Close();
            }
        }

        /// <summary>
        /// https://cuite.codeplex.com/discussions/443094
        /// </summary>
        [TestMethod]
        public void Launch_TempHtmlFile_CanFindHyperlinkByHref()
        {
            // Arrange
            using (TempFile tempFile = new TempFile(
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
                BrowserWindow.Launch(tempFile.FilePath);
                var window = new BrowserWindowUnderTest("test");

                // Assert
                HtmlHyperlink SignUpHyperLink = window.Find<HtmlHyperlink>(By.SearchProperties("href~registration"));
                Assert.IsTrue(SignUpHyperLink.Exists, "SignUp not found");
                
                window.Close();
            }
        }

        /// <summary>
        /// https://cuite.codeplex.com/discussions/443146
        /// </summary>
        [TestMethod]
        public void Launch_TempHtmlFileWithInputWithMaxLength_CanSetTextWhichExceedsMaxLength()
        {
            // Arrange
            using (TempFile tempFile = new TempFile(
@"<html>
    <head>
        <title>test</title>
    </head>
    <body>
        <input id=""input"" type=""text"" maxlength=10 />
    </body>
</html>"))
            {
                BrowserWindow.Launch(tempFile.FilePath);
                var window = new BrowserWindowUnderTest("test");

                HtmlEdit input = window.Find<HtmlEdit>(By.Id("input"));

                // Act
                string inputText = "12345678901";
                string outputText = "1234567890";
                Keyboard.SendKeys(input.SourceControl, inputText);

                // Assert
                Assert.AreEqual(input.Text, outputText);

                window.Close();
            }
        }

        /// <summary>
        /// https://cuite.codeplex.com/discussions/439644
        /// </summary>
        [TestMethod]
        public void GetHtmlDiv_ByClass_Succeeds()
        {
            // Arrange
            using (TempFile tempFile = new TempFile(
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
                BrowserWindow.Launch(tempFile.FilePath);
                var window = new BrowserWindowUnderTest("test");

                // Act
                HtmlDiv div = window.Find<HtmlDiv>(By.Class("button"));

                HtmlHyperlink about = window.Find<HtmlHyperlink>(By.SearchProperties("InnerText=about text;href~about"));
                HtmlDiv div2 = about.Parent as HtmlDiv;

                // Assert
                Assert.IsTrue(div.Exists);
                Assert.AreEqual("main text", div.SourceControl.InnerText);

                Assert.IsTrue(about.Exists);

                Assert.IsTrue(div2.Exists);
                Assert.AreEqual("about text", div2.SourceControl.InnerText);

                window.Close();
            }
        }

        /// <summary>
        /// https://cuite.codeplex.com/discussions/443509
        /// </summary>
        [TestMethod]
        public void GetHtmlRow_ById_Succeeds()
        {
            // Arrange
            using (TempFile tempFile = new TempFile(
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
                BrowserWindow.Launch(tempFile.FilePath);
                var window = new BrowserWindowUnderTest("test");

                // Act
                HtmlRow row = window.Find<HtmlRow>(By.Id("555002_gp2"));

                // Assert
                Assert.IsTrue(row.Exists);

                window.Close();
            }
        }

        [TestMethod]
        public void Enabled_OnDisabledHtmlInputButton_ReturnsFalse()
        {
            // Arrange
            using (TempFile tempFile = new TempFile(
@"<html>
    <head>
        <title>test</title>
    </head>
    <body>
        <input name=""inputName"" type=""submit"" value=""Click here"" disabled=""disabled"" />
    </body>
</html>"))
            {
                BrowserWindow.Launch(tempFile.FilePath);
                var window = new BrowserWindowUnderTest("test");

                HtmlInputButton button = window.Find<HtmlInputButton>(By.ValueAttribute("Click here"));

                // Act and Assert
                Assert.IsFalse(button.Enabled);

                window.Close();
            }
        }

        [TestMethod]
        public void Get_UsingMultipleValuesOfClassAttributeWithContainsOperatorOfHtmlSpan_ReturnsTheSpecificElementWithAllSpecifiedClassValues()
        {
            // Arrange
            using (TempFile tempFile = new TempFile(
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
                BrowserWindow.Launch(tempFile.FilePath);
                var window = new BrowserWindowUnderTest("test");

                HtmlSpan span3 = window.Find<HtmlSpan>(By
                    .Class("class1", PropertyExpressionOperator.Contains)
                    .AndClass("class2", PropertyExpressionOperator.Contains));

                // Act and Assert
                Assert.AreEqual("span3", span3.SourceControl.Name);

                window.Close();
            }
        }

        [TestMethod]
        public void GetSelectedValue_OfRadioButton_Succeeds()
        {
            // Arrange
            using (TempFile tempFile = new TempFile(
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
                BrowserWindow.Launch(tempFile.FilePath);
                var window = new BrowserWindowUnderTest("test");

                // Act
                HtmlRadioButton genderTypeMale = window.Find<HtmlRadioButton>(By.Name("radio:tab1:gender.type.male"));

                // Assert
                Assert.IsTrue(genderTypeMale.Selected);
                Assert.AreEqual("male", genderTypeMale.ValueAttribute);

                window.Close();
            }
        }

        [TestMethod]
        public void SetText_OnHtmlPassword_Succeeds()
        {
            // Arrange
            using (TempFile tempFile = new TempFile(
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
                BrowserWindow.Launch(tempFile.FilePath);
                var window = new BrowserWindowUnderTest("test");

                HtmlPassword txtPwd = window.Find<HtmlPassword>(By.Id("i0118"));

                // Act
                txtPwd.Text = "hello";

                // TODO: Assert
                window.Close();
            }
        }

        /// <summary>
        /// https://cuite.codeplex.com/discussions/522298
        /// </summary>
        [TestMethod]
        public void Click_OnHtmlHyperlink_InTableWithEmptyCell_Succeeds()
        {
            // Arrange
            using (TempFile tempFile = new TempFile(
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
                BrowserWindow.Launch(tempFile.FilePath);
                var window = new BrowserWindowUnderTest("test");
                var table = window.Find<HtmlTable>(By.Id("tableId"));

                HtmlCell cell = table.GetCell(0, 1);
                HtmlHyperlink hyperlink = cell.Find<HtmlHyperlink>();

                // Act
                hyperlink.Click();

                // TODO: Assert
                window.Close();
            }
        }
    }
}

