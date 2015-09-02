using CUITe.SearchConfigurations;
using mshtml;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlTable : HtmlControl<CUITControls.HtmlTable>
    {
        public HtmlTable(By searchConfiguration = null)
            : this(new CUITControls.HtmlTable(), searchConfiguration)
        {
        }

        public HtmlTable(CUITControls.HtmlTable sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        public int ColumnCount
        {
            get
            {
                WaitForControlReady();
                return SourceControl.ColumnCount;
            }
        }

        public int RowCount
        {
            get
            {
                WaitForControlReady();
                return SourceControl.Rows.Count;
            }
        }

        public void FindRowAndClick(int iCol, string sValueToSearch)
        {
            int iRow = FindRow(iCol, sValueToSearch, HtmlTableSearchOptions.Normal);
            FindCellAndClick(iRow, iCol);
        }

        public void FindRowAndClick(int iCol, string sValueToSearch, HtmlTableSearchOptions option)
        {
            int iRow = FindRow(iCol, sValueToSearch, option);
            FindCellAndClick(iRow, iCol);
        }

        public void FindRowAndDoubleClick(int iCol, string sValueToSearch)
        {
            int iRow = FindRow(iCol, sValueToSearch, HtmlTableSearchOptions.Normal);
            FindCellAndDoubleClick(iRow, iCol);
        }

        public void FindRowAndDoubleClick(int iCol, string sValueToSearch, HtmlTableSearchOptions option)
        {
            int iRow = FindRow(iCol, sValueToSearch, option);
            FindCellAndDoubleClick(iRow, iCol);
        }

        public void FindHeaderAndClick(int iRow, int iCol)
        {
            GetHeader(iRow, iCol).Click();
        }

        public void FindCellAndClick(int iRow, int iCol)
        {
            GetCell<HtmlControl<CUITControls.HtmlControl>>(iRow, iCol).Click();
        }

        public void FindCellAndDoubleClick(int iRow, int iCol)
        {
            GetCell(iRow, iCol).DoubleClick();
        }

        public int FindRow(int iCol, string sValueToSearch, HtmlTableSearchOptions option)
        {
            WaitForControlReady();
            int iRow = -1;
            int rowCount = -1;

            foreach (CUITControls.HtmlControl control in SourceControl.Rows)
            {
                //control could be of ControlType.RowHeader or ControlType.Row

                rowCount++;

                int colCount = -1;

                foreach (CUITControls.HtmlControl cell in control.GetChildren()) //Cells could be a collection of HtmlCell and HtmlHeaderCell controls
                {
                    colCount++;
                    bool bSearchOptionResult = false;
                    if (colCount == iCol)
                    {
                        if (option == HtmlTableSearchOptions.Normal)
                        {
                            bSearchOptionResult = (sValueToSearch == cell.InnerText);
                        }
                        else if (option == HtmlTableSearchOptions.NormalTight)
                        {
                            bSearchOptionResult = (sValueToSearch == cell.InnerText.Trim());
                        }
                        else if (option == HtmlTableSearchOptions.StartsWith)
                        {
                            bSearchOptionResult = cell.InnerText.StartsWith(sValueToSearch);
                        }
                        else if (option == HtmlTableSearchOptions.EndsWith)
                        {
                            bSearchOptionResult = cell.InnerText.EndsWith(sValueToSearch);
                        }
                        else if (option == HtmlTableSearchOptions.Greedy)
                        {
                            bSearchOptionResult = (cell.InnerText.IndexOf(sValueToSearch) > -1);
                        }
                        if (bSearchOptionResult)
                        {
                            iRow = rowCount;
                            break;
                        }
                    }
                }
                if (iRow > -1)
                    break;
            }
            return iRow;
        }

        public string GetCellValue(int iRow, int iCol)
        {
            return GetCellValue<HtmlCell>(iRow, iCol);
        }

        public string GetHeaderCellValue(int iRow, int iCol)
        {
            return GetCellValue<HtmlHeaderCell>(iRow, iCol);
        }

        private string GetCellValue<T>(int iRow, int iCol) where T : ControlBase, IHtmlControl
        {
            string innerText = "";
            T htmlCell = GetCell<T>(iRow, iCol);
            if (htmlCell != null)
            {
                innerText = htmlCell.InnerText;
            }

            return innerText;
        }

        public HtmlCheckBox GetEmbeddedCheckBox(int iRow, int iCol)
        {
            string sSearchProperties = "";
            IHTMLElement td = (IHTMLElement)GetCell(iRow, iCol).SourceControl.NativeElement;
            IHTMLElement check = GetEmbeddedCheckBoxNativeElement(td);
            string sOuterHTML = check.outerHTML.Replace("<", "").Replace(">", "").Trim();
            string[] saTemp = sOuterHTML.Split(' ');
            var chk = new CUITControls.HtmlCheckBox(SourceControl.Container);
            foreach (string sTemp in saTemp)
            {
                if (sTemp.IndexOf('=') > 0)
                {
                    string[] saKeyValue = sTemp.Split('=');
                    string sValue = saKeyValue[1];
                    if (saKeyValue[0].ToLower() == "name")
                    {
                        sSearchProperties += ";Name=" + sValue;
                        chk.SearchProperties.Add(UITestControl.PropertyNames.Name, sValue);
                    }
                    if (saKeyValue[0].ToLower() == "id")
                    {
                        sSearchProperties += ";Id=" + sValue;
                        chk.SearchProperties.Add(CUITControls.HtmlControl.PropertyNames.Id, sValue);
                    }
                    if (saKeyValue[0].ToLower() == "class")
                    {
                        sSearchProperties += ";Class=" + sValue;
                        chk.SearchProperties.Add(CUITControls.HtmlControl.PropertyNames.Class, sValue);
                    }
                }
            }

            if (sSearchProperties.Length > 1)
            {
                sSearchProperties = sSearchProperties.Substring(1);
            }
            HtmlCheckBox retChk = new HtmlCheckBox(chk, By.SearchProperties(sSearchProperties));
            return retChk;
        }

        /// <summary>
        /// Gets the column headers of the html table.
        /// </summary>
        /// <returns>string array</returns>
        public string[] GetColumnHeaders()
        {
            string[] retArray;
            UITestControlCollection rows = SourceControl.Rows;
            if ((rows != null) && (rows.Count > 0))
            {
                if ((rows[0] != null) && (rows[0].ControlType == ControlType.RowHeader))
                {
                    var headers = rows[0].GetChildren();
                    retArray = new string[headers.Count];
                    for (int i = 0; i < retArray.Length; i++)
                    {
                        retArray[i] = (string)headers[i].GetProperty("Value");
                    }
                    return retArray;
                }
            }
            return null;
        }

        public HtmlHeaderCell GetHeader(int iRow, int iCol)
        {
            return GetCell<HtmlHeaderCell>(iRow, iCol);
        }

        public HtmlCell GetCell(int iRow, int iCol)
        {
            return GetCell<HtmlCell>(iRow, iCol);
        }

        private T GetCell<T>(int iRow, int iCol) where T : ControlBase, IHtmlControl
        {
            WaitForControlReady();
            UITestControl htmlCell = null;
            int rowCount = -1;

            foreach (UITestControl row in SourceControl.Rows)
            {
                //control could be of ControlType.RowHeader or ControlType.Row

                rowCount++;
                if (rowCount != iRow)
                {
                    continue;
                }

                int colCount = -1;

                foreach (UITestControl cell in row.GetChildren()) //Cells could be a collection of HtmlCell and HtmlHeaderCell controls
                {
                    colCount++;
                    if (colCount != iCol)
                    {
                        continue;
                    }

                    htmlCell = cell;
                    break;
                }

                if (htmlCell != null)
                {
                    break;
                }
            }

            return ControlBaseFactory.Create<T>(htmlCell, null);
        }

        private IHTMLElement GetEmbeddedCheckBoxNativeElement(IHTMLElement parent)
        {
            while (true)
            {
                foreach (IHTMLElement ele2 in parent.children)
                {
                    if (ele2.tagName.ToUpper() == "INPUT")
                    {
                        string sType = ele2.getAttribute("type");
                        if (sType.ToLower() == "checkbox")
                        {
                            return ele2;
                        }
                    }
                    else
                    {
                        if (ele2.children != null)
                        {
                            parent = ele2;
                        }
                    }
                }
            }
        }
    }
}