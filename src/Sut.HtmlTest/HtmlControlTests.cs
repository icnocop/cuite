using System;
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
            pgGHomePage.txtSearch.SetText("Coded UI Test Framework");
            GoogleSearch pgSearch = BrowserWindowUnderTest.GetBrowserWindow<GoogleSearch>();
// ReSharper disable once UnusedVariable
            UITestControlCollection col = pgSearch.divSearchResults.UnWrap().GetChildren();
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
            window.Product.SetText("Tofu");
            Keyboard.SendKeys("{Tab}"); // close drop down menu
            window.Region.SetText("Bloomfield Hills");
            Keyboard.SendKeys("{Tab}"); // close drop down menu
            window.Dealer.SetText("Exotic Liquids");
            Keyboard.SendKeys("{Tab}"); // close drop down menu
            window.PaymentMethod.Click(); // America Express
            Keyboard.SendKeys("{Down}"); // MasterCard
            Keyboard.SendKeys("{Down}"); // Visa
            Keyboard.SendKeys("{Tab}"); // close drop down menu
            window.Close();
        }

        [TestMethod]
        [WorkItem(588)]
        public void HtmlControl_WithInvalidSearchProperties_ThrowsInvalidSearchKeyException()
        {
            //TODO: use known html
            try
            {
                BrowserWindowUnderTest.Launch<GoogleHomePageWithInvalidControlSearchProperties>("http://www.google.com");

                Assert.Fail("InvalidSearchKeyException not thrown");
            }
            catch (TargetInvocationException ex)
            {
                Console.WriteLine(ex.ToString());

                Assert.AreEqual(typeof(InvalidSearchKeyException), ex.InnerException.GetType());
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
                    HtmlDiv div = window.Get<HtmlDiv>("Id=invalid");

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

        [Ignore] //TODO: use known html
        [TestMethod]
        [WorkItem(589)]
        public void HtmlEdit_Wrap_Succeeds()
        {
            GoogleHomePage pgGHomePage = BrowserWindowUnderTest.Launch<GoogleHomePage>("http://www.google.com");
            
            CUITControls.HtmlEdit tmp = new CUITControls.HtmlEdit(pgGHomePage);
            tmp.SearchProperties.Add("Id", "lst-ib");

            HtmlEdit txtEdit = new HtmlEdit();
            txtEdit.WrapReady(tmp);
            txtEdit.SetText("Coded UI Test enhanced Framework");
            GoogleSearch pgSearch = BrowserWindowUnderTest.GetBrowserWindow<GoogleSearch>();
            pgSearch.Close();
        }

        [TestMethod]
        public void HtmlTable_GetColumnHeaders_Succeeds()
        {
            BrowserWindow.Launch(currentDirectory + "/TestHtmlPage.html");
            var bWin = new BrowserWindowUnderTest("A Test");
            var tbl = bWin.Get<HtmlTable>("id=calcWithHeaders");
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

                var table = window.Get<HtmlTable>("id=tableId");

                //Act
                table.FindHeaderAndClick(0, 2);

                window.Close();
            }
        }

        [TestMethod]
        public void HtmlTable_ColumnCount_Succeeds()
        {
            BrowserWindow.Launch(currentDirectory + "/TestHtmlPage.html");
            var bWin = new BrowserWindowUnderTest("A Test");
            var tbl = bWin.Get<HtmlTable>("id=calcWithHeaders");
            Assert.AreEqual(3, tbl.ColumnCount);
            bWin.Close();
        }

        [TestMethod]
        public void HtmlTable_ClickOnColumnHeader_Succeeds()
        {
            BrowserWindow.Launch(currentDirectory + "/TestHtmlPage.html");
            var bWin = new BrowserWindowUnderTest("A Test");
            var tbl = bWin.Get<HtmlTable>("id=tableWithAlertOnHeaderClick");
            tbl.FindHeaderAndClick(0, 0);
            bWin.PerformDialogAction(BrowserDialogAction.Ok);
            bWin.Close();
        }

        [TestMethod]
        [WorkItem(638)]
        public void HtmlTable_FindRowUsingTableWithRowHeaders_Succeeds()
        {
            var bWin = BrowserWindowUnderTest.Launch(currentDirectory + "/TestHtmlPage.html", "A Test");
            var tbl = bWin.Get<HtmlTable>("id=calcWithHeaders");
            tbl.FindRowAndClick(2, "9", HtmlTableSearchOptions.NormalTight);
            Assert.AreEqual("9", tbl.GetCellValue(3, 2).Trim());
            bWin.Close();
        }

        [TestMethod]
        [WorkItem(638)]
        public void HtmlTable_FindRowUsingTableWithoutRowHeaders_Succeeds()
        {
            var bWin = BrowserWindowUnderTest.Launch(currentDirectory + "/TestHtmlPage.html", "A Test");
            var tbl = bWin.Get<HtmlTable>("id=calcWithOutHeaders");
            tbl.FindRowAndClick(2, "9", HtmlTableSearchOptions.NormalTight);
            Assert.AreEqual("9", tbl.GetCellValue(2, 2).Trim());
            bWin.Close();
        }

        [TestMethod]
        public void HtmlTable_GetCellValueWithHeaderCell_Succeeds()
        {
            var bWin = BrowserWindowUnderTest.Launch(currentDirectory + "/TestHtmlPage.html", "A Test");

            var termTable = bWin.Get<HtmlTable>("Id=calcWithHeaderCells");

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

                var table = window.Get<HtmlTable>("id=tableId");

                //Act
                table.FindRowAndClick(0, "LUN_04", HtmlTableSearchOptions.NormalTight);

                //Assert
                Assert.AreEqual("LUN_04", table.GetCellValue(1, 0).Trim());

                window.Close();
            }
        }

        [TestMethod]
        public void HtmlInputButton_UsingSearchParameterWithValueAsKey_Succeeds()
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

                HtmlInputButton button = window.Get<HtmlInputButton>("Value=Log In");

                //Act
                button.Click();

                if (BrowserWindowUnderTest.GetCurrentBrowser() is InternetExplorer)
                {
                    //read JavaScript alert text
                    WinWindow popup = new WinWindow("ClassName=#32770;Name=Message from webpage");
                    WinText text = popup.Get<WinText>();
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

                HtmlInputButton button = window.Get<HtmlInputButton>("Value=Log In");

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

                HtmlFileInput fileInput = window.Get<HtmlFileInput>("Id=inputId");

                string tempInputFilePath = Path.GetTempFileName();

                //Act
                fileInput.SetFile(tempInputFilePath);

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
            bWin.Get<HtmlHyperlink>("Id=idHomePageNewDocument").Click();
            var closeLink = bWin.Get<HtmlHyperlink>("Title=Close;class=ms-dlgCloseBtn");
            //clicking closeLink directly doesn't work as the maximizeLink is clicked due to the controls being placed too close to each other
            Mouse.Click(closeLink.UnWrap().GetChildren()[0].GetChildren()[0]); 
            bWin.RunScript(@"STSNavigate2(event,'/sites/sureba/_layouts/SignOut.aspx');");
        }

        [TestMethod]
        public void HtmlControl_GetChildren_Succeeds()
        {
            var bWin = BrowserWindowUnderTest.Launch(currentDirectory + "/TestHtmlPage.html", "A Test");
            var div = bWin.Get<HtmlDiv>("id=calculatorContainer1");
            var col = div.GetChildren();
            Assert.IsTrue(col[0].SourceType.Name == "HtmlDiv");
            Assert.IsTrue(col[1].SourceType.Name == "HtmlTable");
            Assert.IsTrue(((HtmlDiv)col[0]).InnerText == "calcWithHeaders");
            var tbl = (HtmlTable)col[1];
            Assert.AreEqual("6", tbl.GetCellValue(2, 2).Trim());
            bWin.Close();
        }

        [TestMethod]
        public void HtmlParagraph_InnertText_Succeeds()
        {
            var bWin = BrowserWindowUnderTest.Launch(currentDirectory + "/TestHtmlPage.html", "A Test");
            Assert.IsTrue(bWin.Get<HtmlParagraph>("Id=para1").InnerText.Contains("HtmlParagraph"));
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
                HtmlComboBox comboBox = window.Get<HtmlComboBox>("Id=selectId");

                //Assert
                Assert.AreEqual("Football", comboBox.Items[1]);
                Assert.IsTrue(comboBox.ItemExists("Cricket"));

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
                HtmlComboBox comboBox = window.Get<HtmlComboBox>("Id=selectId");

                comboBox.SelectItem(1);

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
            var bWin = BrowserWindowUnderTest.Launch(currentDirectory + "/TestHtmlPage.html", "A Test");
            var p = bWin.Get<HtmlParagraph>("Id=para1");
            Assert.IsTrue(((HtmlEdit)p.PreviousSibling).UnWrap().Name == "text1_test");
            Assert.IsTrue(((HtmlInputButton)p.NextSibling).ValueAttribute == "sample button");
            Assert.IsTrue(((HtmlDiv)p.Parent).UnWrap().Id == "parentdiv");
            Assert.IsTrue(((HtmlPassword)p.Parent.FirstChild).UnWrap().Name == "pass");
            bWin.Close();
        }

        [TestMethod]
        [DeploymentItem("iframe_test.html")]
        [DeploymentItem("iframe.html")]
        public void HtmlInputButton_ClickInIFrame_Succeeds()
        {
            var bWin = BrowserWindowUnderTest.Launch(currentDirectory + "/iframe_test.html", "iframe Test Main");
            bWin.Get<HtmlInputButton>("Value=Log In").Click();
            bWin.Close();
        }

        [TestMethod]
        [DeploymentItem("iframe_test.html")]
        [DeploymentItem("iframe.html")]
        public void HtmlInputButton_ClickInCUITeIFrame_Succeeds()
        {
            var bWin = BrowserWindowUnderTest.Launch(currentDirectory + "/iframe_test.html", "iframe Test Main");
            HtmlIFrame iFrame = bWin.Get<HtmlIFrame>();
            iFrame.Get<HtmlInputButton>("Value=Log In").Click();
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

                HtmlInputButton button = window.Get<HtmlInputButton>("Value=   Search   ");

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
                HtmlButton button = window.Get<HtmlButton>("id=buttonId");

                //Assert
                Assert.IsTrue(button.Exists);

                Assert.IsTrue(button.UnWrap().ControlDefinition.Contains("style=\"display: none;\""));

                window.Close();
            }
        }

        [TestMethod]
        public void HtmlUnorderedList_WithListItems_CanAssertOnListItems()
        {
            var bWin = BrowserWindowUnderTest.Launch(currentDirectory + "/TestHtmlPage.html", "A Test");

            var list = bWin.Get<HtmlUnorderedList>("id=unorderedList");

            List<HtmlListItem> children = (from i in list.GetChildren()
                                                       select i as HtmlListItem).ToList();
            Assert.AreEqual(3, children.Count());

            Assert.AreEqual(1, children.Count(x => x.InnerText == "List Item 1"));
            Assert.AreEqual(1, children.Count(x => x.InnerText == "List Item 2"));
            Assert.AreEqual(1, children.Count(x => x.InnerText == "List Item 3"));

            bWin.Close();
        }

        [TestMethod]
        public void HtmlUnorderedListInObjectRepository_WithListItems_CanAssertOnListItems()
        {
            TestHtmlPage bWin = BrowserWindowUnderTest.Launch<TestHtmlPage>(currentDirectory + "/TestHtmlPage.html");

            List<HtmlListItem> children = (from i in bWin.list.GetChildren()
                                                 select i as HtmlListItem).ToList();
            Assert.AreEqual(3, children.Count());

            Assert.AreEqual(1, children.Count(x => x.InnerText == "List Item 1"));
            Assert.AreEqual(1, children.Count(x => x.InnerText == "List Item 2"));
            Assert.AreEqual(1, children.Count(x => x.InnerText == "List Item 3"));

            bWin.Close();
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
                HtmlCheckBox checkBox = window.Get<HtmlCheckBox>("id=checkBoxId");

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
                var window = BrowserWindowUnderTest.Launch(tempFile.FilePath, "test");

                HtmlComboBox comboBox = window.Get<HtmlComboBox>("Id=selectId");

                comboBox.SetFocus();

                //Act
                // select item "Banana"
                Keyboard.SendKeys(comboBox.UnWrap(), "{DOWN}");

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
                HtmlDiv div = window.Get<HtmlDiv>("id=div1");
                HtmlEdit inputTextBox = div.Get<HtmlEdit>();

                //Act
                inputTextBox.SetText("text");

                //Assert
                Assert.AreEqual("text", inputTextBox.GetText());

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
                var bWin = BrowserWindowUnderTest.Launch(tempFile.FilePath, "test");

                // Act
                HtmlCustom txtUserName = bWin.Get<HtmlCustom>("input");
                txtUserName.SetSearchProperties("id=i0116");

                // Assert
                Assert.IsTrue(txtUserName.Exists);

                Keyboard.SendKeys(txtUserName.UnWrap(), "hello");

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
                HtmlList list = bWin.Get<HtmlList>("id=selectId");

                string[] itemsToSelect = { "1", "2" };

                //Act
                list.SelectedItems = itemsToSelect;

                //Assert
                CollectionAssert.AreEqual(itemsToSelect, list.SelectedItems);

                bWin.Close();
            }
        }

        [TestMethod]
        public void Click_OnHtmlInputButtonWithEqualsSignInSearchParameterValue_Succeeds()
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

                HtmlInputButton button = window.Get<HtmlInputButton>("Value==");

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

                HtmlComboBox comboBox = window.Get<HtmlComboBox>("Id=selectId");
                
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

                HtmlLabel label = window.Get<HtmlLabel>("id=other");

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

                IControlBase a = window.Get<HtmlHyperlink>("InnerText=test");
                a.Click();

                List<Type> list = new List<Type>();
                list.Add(typeof(HtmlHyperlink));
                list.Add(typeof(HtmlButton));
                list.Add(typeof(HtmlEdit));

                MethodInfo getMethodInfo = typeof(BrowserWindowUnderTest).GetMethod("Get");

                foreach(Type t in list)
                {
                    MethodInfo test = getMethodInfo.MakeGenericMethod(t);
                    
                    IControlBase control;

                    if ((t == typeof(HtmlEdit)) || (t == typeof(HtmlTextArea)))
                    {
                        control = (IControlBase)test.Invoke(window, new object[] { "Value=test" });
                    }
                    else
                    {
                        //window.Get<t>("InnerText=test");
                        control = (IControlBase)test.Invoke(window, new object[] { "InnerText=test" });
                    }

                    //Act
                    control.Click();

                    if (control is HtmlEdit)
                    {
                        (control as HtmlEdit).SetText("text");
                    }
                    else if (control is HtmlTextArea)
                    {
                        (control as HtmlTextArea).SetText("text");
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
                window.div1.div2.edit.SetText("test");

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
                List<IControlBase> collection = window.Get<HtmlDiv>("id=div1").GetChildren();
                foreach (IControlBase control in collection)
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
                HtmlButton button = window.Get<HtmlButton>("id=buttonId");

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

                CUITControls.HtmlCustom cus = new CUITControls.HtmlCustom(window.divFeedTabs.UnWrap());
                cus.SearchProperties.Add(CUITControls.HtmlControl.PropertyNames.TagName, "ul", PropertyExpressionOperator.EqualTo);
                cus.SearchProperties.Add(CUITControls.HtmlControl.PropertyNames.Class, "dataFeedTab ui-tabs-nav", PropertyExpressionOperator.EqualTo);

                Assert.IsTrue(cus.Exists);

                HtmlCustom cusDataFeedTabsNav = window.Get<HtmlCustom>("ul");
                cusDataFeedTabsNav.SetSearchProperties("Class=dataFeedTab ui-tabs-nav");
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
                HtmlHyperlink SignUpHyperLink = window.Get<HtmlHyperlink>("href~registration");
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

                HtmlEdit input = window.Get<HtmlEdit>("id=input");

                // Act
                string inputText = "12345678901";
                string outputText = "1234567890";
                Keyboard.SendKeys(input.UnWrap(), inputText);

                // Assert
                Assert.AreEqual(input.GetText(), outputText);

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
                HtmlDiv div = window.Get<HtmlDiv>("class=button");

                HtmlHyperlink about = window.Get<HtmlHyperlink>("InnerText=about text;href~about");
                HtmlDiv div2 = about.Parent as HtmlDiv;

                // Assert
                Assert.IsTrue(div.Exists);
                Assert.AreEqual("main text", div.UnWrap().InnerText);

                Assert.IsTrue(about.Exists);

                Assert.IsTrue(div2.Exists);
                Assert.AreEqual("about text", div2.UnWrap().InnerText);

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
                HtmlRow row = window.Get<HtmlRow>("id=555002_gp2");

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

                HtmlInputButton button = window.Get<HtmlInputButton>("Value=Click here");

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

                HtmlSpan span3 = window.Get<HtmlSpan>("Class~class1;Class~class2");

                // Act and Assert
                Assert.AreEqual("span3", span3.UnWrap().Name);

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
                HtmlRadioButton genderTypeMale = window.Get<HtmlRadioButton>("Name=radio:tab1:gender.type.male");

                // Assert
                Assert.IsTrue(genderTypeMale.IsSelected);
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

                HtmlPassword txtPwd = window.Get<HtmlPassword>("id=i0118");

                // Act
                txtPwd.SetText("hello");

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
                var table = window.Get<HtmlTable>("Id=tableId");

                HtmlCell cell = table.GetCell(0, 1);
                HtmlHyperlink hyperlink = cell.Get<HtmlHyperlink>();

                // Act
                hyperlink.Click();

                // TODO: Assert
                window.Close();
            }
        }
    }
}

