using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using CUITe;
using CUITe.Controls.HtmlControls;
using CUITe.Controls.WinControls;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sample_CUITeTestProject.ObjectRepository;

namespace Sample_CUITeTestProject
{
    [CodedUITest]
    [DeploymentItem(@"Sample_CUITeTestProject\XMLFile2.xml")]
    [DeploymentItem(@"Sample_CUITeTestProject\TestHtmlPage.html")]
    public class HtmlControlTests
    {
        private string CurrentDirectory = Directory.GetCurrentDirectory();

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestInitialize]
        public void TestInitialize()
        {
            //CUITe_BrowserWindow.CloseAllBrowsers();
        }

        [TestMethod]
        public void HtmlEdit_SetText_Succeeds()
        {
            GoogleHomePage pgGHomePage = CUITe_BrowserWindow.Launch<GoogleHomePage>("http://www.google.com");
            pgGHomePage.txtSearch.SetText("Coded UI Test Framework");
            GoogleSearch pgSearch = CUITe_BrowserWindow.GetBrowserWindow<GoogleSearch>();
            UITestControlCollection col = pgSearch.divSearchResults.UnWrap().GetChildren();
            //do something with collection
            pgSearch.Close();
        }

        [TestMethod]
        public void DataManager_GetDataRowUsingEmbeddedResource_Succeeds()
        {
            Hashtable ht = CUITe.CUITe_DataManager.GetDataRow(Type.GetType("Sample_CUITeTestProject.HtmlControlTests"), "XMLFile1.xml", "tc2");
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
        //    Hashtable ht = CUITe.CUITe_DataManager.GetDataRow("XMLFile2.xml", "content2");
        //    Assert.AreEqual("SomeTest", ht["test"]);
        //    Assert.AreEqual("Somewhere, Somewhere", ht["address"]);
        //    Assert.AreEqual("SomeFirstName", ht["firstname"]);
        //    Assert.AreEqual("SomeLastNameBigger", ht["lastname"]);
        //    Assert.AreEqual("01/01/1900", ht["dob"]);
        //    Assert.AreEqual("101", ht["age"]);
        //    Assert.AreEqual("USA", ht["nationality"]);
        //}

        [TestMethod]
        public void SetText_OnTelerikASPNETComboBox_SelectsItemByText()
        {
            DemosOfTeleriksASPNETComboBoxControl window = CUITe_BrowserWindow.Launch<DemosOfTeleriksASPNETComboBoxControl>(
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
            try
            {
                GoogleHomePageWithInvalidControlSearchProperties pgGHome = CUITe_BrowserWindow.Launch<GoogleHomePageWithInvalidControlSearchProperties>("http://www.google.com");

                Assert.Fail("CUITe_InvalidSearchKey not thrown");
            }
            catch (System.Reflection.TargetInvocationException ex)
            {
                Console.WriteLine(ex.ToString());

                Assert.AreEqual(typeof(CUITe_InvalidSearchKey), ex.InnerException.GetType());
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
                    CUITe_BrowserWindow.Launch(tempFile.FilePath);
                    CUITe_BrowserWindow window = new CUITe_BrowserWindow("test");

                    //Act
                    CUITe_HtmlDiv div = window.Get<CUITe_HtmlDiv>("Id=invalid");

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
        [WorkItem(589)]
        public void HtmlEdit_Wrap_Succeeds()
        {
            GoogleHomePage pgGHomePage = CUITe_BrowserWindow.Launch<GoogleHomePage>("http://www.google.com");
            
            HtmlEdit tmp = new HtmlEdit(pgGHomePage);
            tmp.SearchProperties.Add("Id", "lst-ib");

            CUITe_HtmlEdit txtEdit = new CUITe_HtmlEdit();
            txtEdit.WrapReady(tmp);
            txtEdit.SetText("Coded UI Test enhanced Framework");
            GoogleSearch pgSearch = CUITe_BrowserWindow.GetBrowserWindow<GoogleSearch>();
            pgSearch.Close();
        }

        [TestMethod]
        public void HtmlTable_GetColumnHeaders_Succeeds()
        {
            CUITe_BrowserWindow.Launch(CurrentDirectory + "/TestHtmlPage.html");
            CUITe_BrowserWindow bWin = new CUITe_BrowserWindow("A Test");
            CUITe_HtmlTable tbl = bWin.Get<CUITe_HtmlTable>("id=calcWithHeaders");
            string[] saExpectedValues = new string[] { "Header1", "Header2", "Header3" };
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

                CUITe_BrowserWindow.Launch(tempFile.FilePath);
                CUITe_BrowserWindow window = new CUITe_BrowserWindow("test");

                CUITe_HtmlTable table = window.Get<CUITe_HtmlTable>("id=tableId");

                //Act
                table.FindHeaderAndClick(0, 2);

                window.Close();
            }
        }

        [TestMethod]
        public void HtmlTable_ColumnCount_Succeeds()
        {
            CUITe_BrowserWindow.Launch(CurrentDirectory + "/TestHtmlPage.html");
            CUITe_BrowserWindow bWin = new CUITe_BrowserWindow("A Test");
            CUITe_HtmlTable tbl = bWin.Get<CUITe_HtmlTable>("id=calcWithHeaders");
            Assert.AreEqual(3, tbl.ColumnCount);
            bWin.Close();
        }

        [TestMethod]
        public void HtmlTable_ClickOnColumnHeader_Succeeds()
        {
            CUITe_BrowserWindow.Launch(CurrentDirectory + "/TestHtmlPage.html");
            CUITe_BrowserWindow bWin = new CUITe_BrowserWindow("A Test");
            CUITe_HtmlTable tbl = bWin.Get<CUITe_HtmlTable>("id=tableWithAlertOnHeaderClick");
            tbl.FindHeaderAndClick(0, 0);
            bWin.PerformDialogAction(BrowserDialogAction.Ok);
            bWin.Close();
        }

        [TestMethod]
        [WorkItem(638)]
        public void HtmlTable_FindRowUsingTableWithRowHeaders_Succeeds()
        {
            CUITe_BrowserWindow bWin = CUITe_BrowserWindow.Launch(CurrentDirectory + "/TestHtmlPage.html", "A Test");
            CUITe_HtmlTable tbl = bWin.Get<CUITe_HtmlTable>("id=calcWithHeaders");
            tbl.FindRowAndClick(2, "9", CUITe_HtmlTableSearchOptions.NormalTight);
            Assert.AreEqual("9", tbl.GetCellValue(3, 2).Trim());
            bWin.Close();
        }

        [TestMethod]
        [WorkItem(638)]
        public void HtmlTable_FindRowUsingTableWithoutRowHeaders_Succeeds()
        {
            CUITe_BrowserWindow bWin = CUITe_BrowserWindow.Launch(CurrentDirectory + "/TestHtmlPage.html", "A Test");
            CUITe_HtmlTable tbl = bWin.Get<CUITe_HtmlTable>("id=calcWithOutHeaders");
            tbl.FindRowAndClick(2, "9", CUITe_HtmlTableSearchOptions.NormalTight);
            Assert.AreEqual("9", tbl.GetCellValue(2, 2).Trim());
            bWin.Close();
        }

        [TestMethod]
        public void HtmlTable_GetCellValueWithHeaderCell_Succeeds()
        {
            CUITe_BrowserWindow bWin = CUITe_BrowserWindow.Launch(CurrentDirectory + "/TestHtmlPage.html", "A Test");

            CUITe_HtmlTable termTable = bWin.Get<CUITe_HtmlTable>("Id=calcWithHeaderCells");

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
                CUITe_BrowserWindow.Launch(tempFile.FilePath);
                CUITe_BrowserWindow window = new CUITe_BrowserWindow("test");

                CUITe_HtmlTable table = window.Get<CUITe_HtmlTable>("id=tableId");

                //Act
                table.FindRowAndClick(0, "LUN_04", CUITe_HtmlTableSearchOptions.NormalTight);

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
                CUITe_BrowserWindow.Launch(tempFile.FilePath);
                CUITe_BrowserWindow window = new CUITe_BrowserWindow("test");

                CUITe_HtmlInputButton button = window.Get<CUITe_HtmlInputButton>("Value=Log In");

                //Act
                button.Click();

                if (CUITe_BrowserWindow.GetCurrentBrowser() is CUITe.Browsers.InternetExplorer)
                {
                    //read JavaScript alert text
                    CUITe_WinWindow popup = new CUITe_WinWindow("ClassName=#32770;Name=Message from webpage");
                    CUITe_WinText text = popup.Get<CUITe_WinText>();
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
                CUITe_BrowserWindow.Launch(tempFile.FilePath);
                CUITe_BrowserWindow window = new CUITe_BrowserWindow("test");

                CUITe_HtmlInputButton button = window.Get<CUITe_HtmlInputButton>("Value=Log In");

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
                CUITe_BrowserWindow.Launch(tempFile.FilePath);
                CUITe_BrowserWindow window = new CUITe_BrowserWindow("test");

                CUITe_HtmlFileInput fileInput = window.Get<CUITe_HtmlFileInput>("Id=inputId");

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
            CUITe_BrowserWindow.Launch("http://myasia/sites/sureba/Default.aspx");
            CUITe_BrowserWindow.Authenticate("username", "passwd");
            CUITe_BrowserWindow bWin = new CUITe_BrowserWindow("Suresh Balasubramanian");
            bWin.Get<CUITe_HtmlHyperlink>("Id=idHomePageNewDocument").Click();
            var closeLink = bWin.Get<CUITe_HtmlHyperlink>("Title=Close;class=ms-dlgCloseBtn");
            //clicking closeLink directly doesn't work as the maximizeLink is clicked due to the controls being placed too close to each other
            Mouse.Click(closeLink.UnWrap().GetChildren()[0].GetChildren()[0]); 
            bWin.RunScript(@"STSNavigate2(event,'/sites/sureba/_layouts/SignOut.aspx');");
        }

        [TestMethod]
        public void HtmlControl_GetChildren_Succeeds()
        {
            CUITe_BrowserWindow bWin = CUITe_BrowserWindow.Launch(CurrentDirectory + "/TestHtmlPage.html", "A Test");
            var div = bWin.Get<CUITe_HtmlDiv>("id=calculatorContainer1");
            var col = div.GetChildren();
            Assert.IsTrue(col[0].GetBaseType().Name == "HtmlDiv");
            Assert.IsTrue(col[1].GetBaseType().Name == "HtmlTable");
            Assert.IsTrue(((CUITe_HtmlDiv)col[0]).InnerText == "calcWithHeaders");
            var tbl = (CUITe_HtmlTable)col[1];
            Assert.AreEqual("6", tbl.GetCellValue(2, 2).Trim());
            bWin.Close();
        }

        [TestMethod]
        public void HtmlParagraph_InnertText_Succeeds()
        {
            CUITe_BrowserWindow bWin = CUITe_BrowserWindow.Launch(CurrentDirectory + "/TestHtmlPage.html", "A Test");
            Assert.IsTrue(bWin.Get<CUITe_HtmlParagraph>("Id=para1").InnerText.Contains("CUITe_HtmlParagraph"));
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
                CUITe_BrowserWindow.Launch(tempFile.FilePath);
                CUITe_BrowserWindow window = new CUITe_BrowserWindow("test");

                //Act
                CUITe_HtmlComboBox comboBox = window.Get<CUITe_HtmlComboBox>("Id=selectId");

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
                CUITe_BrowserWindow.Launch(tempFile.FilePath);
                CUITe_BrowserWindow window = new CUITe_BrowserWindow("test");

                //Act
                CUITe_HtmlComboBox comboBox = window.Get<CUITe_HtmlComboBox>("Id=selectId");

                comboBox.SelectItem(1);

                //Assert
                Assert.AreEqual("Football", comboBox.SelectedItem);

                window.Close();
            }
        }

        [TestMethod]
        public void HtmlParagraph_InObjectRepository_Succeeds()
        {
            TestHtmlPage testpage = CUITe_BrowserWindow.Launch<TestHtmlPage>(CurrentDirectory + "/TestHtmlPage.html");
            string content = testpage.p.InnerText;
            Assert.IsTrue(content.Contains("CUITe_HtmlParagraph"));
            testpage.Close();
        }

        [TestMethod]
        public void HtmlParagraph_TraverseSiblingsParentAndChildren_Succeeds()
        {
            CUITe_BrowserWindow bWin = CUITe_BrowserWindow.Launch(CurrentDirectory + "/TestHtmlPage.html", "A Test");
            var p = bWin.Get<CUITe_HtmlParagraph>("Id=para1");
            Assert.IsTrue(((CUITe_HtmlEdit)p.PreviousSibling).UnWrap().Name == "text1_test");
            Assert.IsTrue(((CUITe_HtmlInputButton)p.NextSibling).ValueAttribute == "sample button");
            Assert.IsTrue(((CUITe_HtmlDiv)p.Parent).UnWrap().Id == "parentdiv");
            Assert.IsTrue(((CUITe_HtmlPassword)p.Parent.FirstChild).UnWrap().Name == "pass");
            bWin.Close();
        }

        [TestMethod]
        [DeploymentItem(@"Sample_CUITeTestProject\iframe_test.html")]
        [DeploymentItem(@"Sample_CUITeTestProject\iframe.html")]
        public void HtmlInputButton_ClickInIFrame_Succeeds()
        {
            CUITe_BrowserWindow bWin = CUITe_BrowserWindow.Launch(CurrentDirectory + "/iframe_test.html", "iframe Test Main");
            bWin.Get<CUITe_HtmlInputButton>("Value=Log In").Click();
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
                CUITe_BrowserWindow.Launch(tempFile.FilePath);
                CUITe_BrowserWindow window = new CUITe_BrowserWindow("test");

                CUITe_HtmlInputButton button = window.Get<CUITe_HtmlInputButton>("Value=   Search   ");

                //Act
                button.Click();

                window.Close();
            }
        }

        [TestMethod]
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
                CUITe_BrowserWindow.Launch(tempFile.FilePath);
                CUITe_BrowserWindow window = new CUITe_BrowserWindow("test");

                //Act
                CUITe_HtmlButton button = window.Get<CUITe_HtmlButton>("id=buttonId");

                //Assert
                Assert.IsTrue(button.Exists);

                Assert.IsTrue(button.UnWrap().ControlDefinition.Contains("style=\"DISPLAY: none\""));

                window.Close();
            }
        }

        [TestMethod]
        public void HtmlUnorderedList_WithListItems_CanAssertOnListItems()
        {
            CUITe_BrowserWindow bWin = CUITe_BrowserWindow.Launch(CurrentDirectory + "/TestHtmlPage.html", "A Test");

            CUITe_HtmlUnorderedList list = bWin.Get<CUITe_HtmlUnorderedList>("id=unorderedList");

            IEnumerable<CUITe_HtmlListItem> children = from i in list.GetChildren()
                                                       select i as CUITe_HtmlListItem;
            Assert.AreEqual(3, children.Count());

            Assert.AreEqual(1, children.Count(x => x.InnerText == "List Item 1 "));
            Assert.AreEqual(1, children.Count(x => x.InnerText == "List Item 2 "));
            Assert.AreEqual(1, children.Count(x => x.InnerText == "List Item 3 "));

            bWin.Close();
        }

        [TestMethod]
        public void HtmlUnorderedListInObjectRepository_WithListItems_CanAssertOnListItems()
        {
            TestHtmlPage bWin = CUITe_BrowserWindow.Launch<TestHtmlPage>(CurrentDirectory + "/TestHtmlPage.html");

            IEnumerable<CUITe_HtmlListItem> children = from i in bWin.list.GetChildren()
                                                       select i as CUITe_HtmlListItem;
            Assert.AreEqual(3, children.Count());

            Assert.AreEqual(1, children.Count(x => x.InnerText == "List Item 1 "));
            Assert.AreEqual(1, children.Count(x => x.InnerText == "List Item 2 "));
            Assert.AreEqual(1, children.Count(x => x.InnerText == "List Item 3 "));

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
                CUITe_BrowserWindow.Launch(tempFile.FilePath);
                CUITe_BrowserWindow window = new CUITe_BrowserWindow("test");

                //Act
                CUITe_HtmlCheckBox checkBox = window.Get<CUITe_HtmlCheckBox>("id=checkBoxId");

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
                CUITe_BrowserWindow.Launch(tempFile.FilePath);
                CUITe_BrowserWindow window = new CUITe_BrowserWindow("test");

                CUITe_HtmlComboBox comboBox = window.Get<CUITe_HtmlComboBox>("Id=selectId");

                //Act
                comboBox.SelectItem("Banana");

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
                CUITe_BrowserWindow.Launch(tempFile.FilePath);
                CUITe_BrowserWindow window = new CUITe_BrowserWindow("test");
                CUITe_HtmlDiv div = window.Get<CUITe_HtmlDiv>("id=div1");
                CUITe_HtmlEdit inputTextBox = div.Get<CUITe_HtmlEdit>();

                //Act
                inputTextBox.SetText("text");

                //Assert
                Assert.AreEqual("text", inputTextBox.GetText());

                window.Close();
            }
        }

        [TestMethod]
        public void SetText_OnHtmlEditWithOverlappedDiv_Succeeds()
        {
            //Arrange
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
                CUITe_BrowserWindow.Launch(tempFile.FilePath);
                CUITe_BrowserWindow bWin = new CUITe_BrowserWindow("test");
                CUITe_HtmlEdit txtUserName = bWin.Get<CUITe_HtmlEdit>("id=i0116");

                //Act
                txtUserName.SetText("hello");

                //Assert
                Assert.AreEqual("hello", txtUserName.GetText());

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
                CUITe_BrowserWindow.Launch(tempFile.FilePath);
                CUITe_BrowserWindow bWin = new CUITe_BrowserWindow("test");
                CUITe_HtmlList list = bWin.Get<CUITe_HtmlList>("id=selectId");

                string[] itemsToSelect = new string[] { "1", "2" };

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
                CUITe_BrowserWindow.Launch(tempFile.FilePath);
                CUITe_BrowserWindow window = new CUITe_BrowserWindow("test");

                CUITe_HtmlInputButton button = window.Get<CUITe_HtmlInputButton>("Value==");

                //Act
                button.Click();

                window.PerformDialogAction(BrowserDialogAction.Ok);

                window.Close();
            }
        }
    }
}

