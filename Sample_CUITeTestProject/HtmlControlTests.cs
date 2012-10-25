using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using CUITe;
using CUITe.Controls.HtmlControls;
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
        public void TelerikComboBox_SelectItemByText_Succeeds()
        {
            ASPNETComboBoxDemoFirstLook pgPage = CUITe_BrowserWindow.Launch<ASPNETComboBoxDemoFirstLook>(
                "http://demos.telerik.com/aspnet-ajax/combobox/examples/default/defaultcs.aspx");
            Thread.Sleep(5000);
            pgPage.Refresh();
            Thread.Sleep(5000);
            pgPage.combo1.SelectItemByText("Tofu", 5000);
            pgPage.combo2.SelectItemByText("Bloomfield Hills", 5000);
            pgPage.combo3.SelectItemByText("Exotic Liquids", 5000);
            pgPage.combo4.SelectItemByText("American Express", 5000);
            pgPage.Close();
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
            Playback.PlaybackSettings.SmartMatchOptions = SmartMatchOptions.None; //required if you are using .Exists on an invalid control
            CUITe_BrowserWindow.Launch("http://www.google.com");
            GoogleHomePage pgGHomePage = CUITe_BrowserWindow.GetBrowserWindow<GoogleHomePage>();
            Assert.IsFalse(pgGHomePage.divNonExistent.Exists);
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
            CUITe_BrowserWindow bWin = CUITe_BrowserWindow.Launch(CurrentDirectory + "/TestHtmlPage.html", "A Test");
            CUITe_HtmlTable tbl = bWin.Get<CUITe_HtmlTable>("id=QuarterlyTable");
            tbl.FindHeaderAndClick(0, 2);
            bWin.Close();
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
            Assert.IsTrue(tbl.GetCellValue(2, 2).Trim() == "9");
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
            CUITe_BrowserWindow.Launch(CurrentDirectory + "/TestHtmlPage.html");
            CUITe_BrowserWindow bWin = new CUITe_BrowserWindow("A Test");
            CUITe_HtmlTable tbl = bWin.Get<CUITe_HtmlTable>("id=TabContainer1_TabPanel1_gvSourceLuns");
            tbl.FindRowAndClick(0, "LUN_04", CUITe_HtmlTableSearchOptions.NormalTight);
            Assert.AreEqual("LUN_04", tbl.GetCellValue(1, 0).Trim());
            bWin.Close();
        }

        [TestMethod]
        public void HtmlInputButton_UsingSearchParameterWithValueAsKey_Succeeds()
        {
            //Internet Explorer may display the message: Internet Explorer restricted this webpage from running scripts or ActiveX controls.
            //This security restriction prevents the alert message to appear.
            //To enable running scripts on the local computer, go to Tools > Internet options > Advanced > Security > [checkmark] Allow active content to run in files on My Computer

            CUITe_BrowserWindow bWin = CUITe_BrowserWindow.Launch(CurrentDirectory + "/TestHtmlPage.html", "A Test");
            bWin.Get<CUITe_HtmlInputButton>("Value=Log In").Click();

            bWin.PerformDialogAction(BrowserDialogAction.Ok);

            bWin.Close();
        }

        [TestMethod]
        public void HtmlFileInput_SetFile_Succeeds()
        {
            CUITe_BrowserWindow bWin = CUITe_BrowserWindow.Launch(CurrentDirectory + "/TestHtmlPage.html", "A Test");
            bWin.Get<CUITe_HtmlFileInput>("Id=ctl00_PlaceHolderMain_ctl01_ctl02_InputFile").SetFile(@"C:\Demo\info.txt");
            bWin.Close();
        }

        [TestMethod]
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
            Assert.IsTrue(tbl.GetCellValue(2, 2).Trim() == "9");
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
            CUITe_BrowserWindow bWin = CUITe_BrowserWindow.Launch(CurrentDirectory + "/TestHtmlPage.html", "A Test");
            CUITe_HtmlComboBox cmb = bWin.Get<CUITe_HtmlComboBox>("Id=select1");
            Assert.AreEqual("Football", cmb.Items[1]);
            Assert.IsTrue(cmb.ItemExists("Cricket"));
            bWin.Close();
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
            CUITe_BrowserWindow bWin = CUITe_BrowserWindow.Launch(CurrentDirectory + "/TestHtmlPage.html", "A Test");

            CUITe_HtmlInputButton btnSearch = bWin.Get<CUITe_HtmlInputButton>("Value=   Search   ");
            btnSearch.Click();

            bWin.Close();
        }

        [TestMethod]
        public void HtmlButton_HiddenByStyle_ControlExistsAndCanAssertOnStyle()
        {
            CUITe_BrowserWindow bWin = CUITe_BrowserWindow.Launch(CurrentDirectory + "/TestHtmlPage.html", "A Test");

            CUITe_HtmlButton btnHiddenButton = bWin.Get<CUITe_HtmlButton>("id=hiddenButton");

            Assert.IsTrue(btnHiddenButton.Exists);

            Assert.IsTrue(btnHiddenButton.UnWrap().ControlDefinition.Contains("style=\"DISPLAY: none\""));

            bWin.Close();
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
            CUITe_BrowserWindow bWin = CUITe_BrowserWindow.Launch(CurrentDirectory + "/TestHtmlPage.html", "A Test");

            CUITe_HtmlCheckBox chkBox1 = bWin.Get<CUITe_HtmlCheckBox>("id=checkBox1");

            Assert.IsTrue(chkBox1.Exists);
            Assert.IsTrue(chkBox1.Checked);

            bWin.Close();
        }
    }
}

