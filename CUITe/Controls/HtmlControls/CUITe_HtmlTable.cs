using System.Linq;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public enum CUITe_HtmlTableSearchOptions
    {
        Normal,
        NormalTight,
        Greedy,
        StartsWith,
        EndsWith
    }

    public class CUITe_HtmlTable : CUITe_HtmlControl<HtmlTable>
    {
        public CUITe_HtmlTable() : base() { }
        public CUITe_HtmlTable(string searchParameters) : base(searchParameters) { }

        public int ColumnCount
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.ColumnCount;
            }
        }

        public int RowCount
        {
            get {
                this._control.WaitForControlReady();
                return this._control.Rows.Count; 
            }
        }

        public void FindRowAndClick(int iCol, string sValueToSearch)
        {
            int iRow = FindRow(iCol, sValueToSearch, CUITe_HtmlTableSearchOptions.Normal);
            FindCellAndClick(iRow, iCol);
        }

        public void FindRowAndClick(int iCol, string sValueToSearch, CUITe_HtmlTableSearchOptions option)
        {
            int iRow = FindRow(iCol, sValueToSearch, option);
            FindCellAndClick(iRow, iCol);
        }

        public void FindRowAndDoubleClick(int iCol, string sValueToSearch)
        {
            int iRow = FindRow(iCol, sValueToSearch, CUITe_HtmlTableSearchOptions.Normal);
            FindCellAndDoubleClick(iRow, iCol);
        }

        public void FindRowAndDoubleClick(int iCol, string sValueToSearch, CUITe_HtmlTableSearchOptions option)
        {
            int iRow = FindRow(iCol, sValueToSearch, option);
            FindCellAndDoubleClick(iRow, iCol);
        }

        public void FindHeaderAndClick(int iRow, int iCol)
        {
            this.GetHeader(iRow, iCol).Click();
        }

        public void FindCellAndClick(int iRow, int iCol)
        {
            this.GetCell(iRow, iCol).Click();
        }

        public void FindCellAndDoubleClick(int iRow, int iCol)
        {
            this.GetCell(iRow, iCol).DoubleClick();
        }

        public int FindRow(int iCol, string sValueToSearch, CUITe_HtmlTableSearchOptions option)
        {
            this._control.WaitForControlReady();
            int iRow = -1;
            int rowCount = -1;

            UITestControlCollection coltemp = RemoveRowHeaders(this._control.Rows);

            foreach (HtmlRow cont in coltemp)
            {
                rowCount++;
                int colCount = -1;
                foreach (HtmlControl cell in cont.Cells) //Cells could be a collection of HtmlCell and HtmlHeaderCell controls
                {
                    colCount++;
                    bool bSearchOptionResult = false;
                    if (colCount == iCol)
                    {
                        if (option == CUITe_HtmlTableSearchOptions.Normal)
                        {
                            bSearchOptionResult = (sValueToSearch == cell.InnerText);
                        }
                        else if (option == CUITe_HtmlTableSearchOptions.NormalTight)
                        {
                            bSearchOptionResult = (sValueToSearch == cell.InnerText.Trim());
                        }
                        else if (option == CUITe_HtmlTableSearchOptions.StartsWith)
                        {
                            bSearchOptionResult = cell.InnerText.StartsWith(sValueToSearch);
                        }
                        else if (option == CUITe_HtmlTableSearchOptions.EndsWith)
                        {
                            bSearchOptionResult = cell.InnerText.EndsWith(sValueToSearch);
                        }
                        else if (option == CUITe_HtmlTableSearchOptions.Greedy)
                        {
                            bSearchOptionResult = (cell.InnerText.IndexOf(sValueToSearch) > -1);
                        }
                        if (bSearchOptionResult == true)
                        {
                            iRow = rowCount;
                            break;
                        }
                    }
                }
                if (iRow > -1) break;
            }
            return iRow;
        }

        public string GetCellValue(int iRow, int iCol)
        {
            string innerText = "";
            CUITe_HtmlCell htmlCell = this.GetCell(iRow, iCol);
            if (htmlCell != null)
            {
                innerText = htmlCell.InnerText;
            }

            return innerText;
        }

        public CUITe_HtmlCheckBox GetEmbeddedCheckBox(int iRow, int iCol)
        {
            string sSearchProperties = "";
            mshtml.IHTMLElement td = (mshtml.IHTMLElement)GetCell(iRow, iCol).UnWrap().NativeElement;
            mshtml.IHTMLElement check = GetEmbeddedCheckBoxNativeElement(td);
            string sOuterHTML = check.outerHTML.Replace("<", "").Replace(">", "").Trim();
            string[] saTemp = sOuterHTML.Split(' ');
            HtmlCheckBox chk = new HtmlCheckBox(this._control.Container);
            foreach (string sTemp in saTemp)
            {
                if (sTemp.IndexOf('=') > 0)
                {
                    string[] saKeyValue = sTemp.Split('=');
                    string sValue = saKeyValue[1];
                    if (saKeyValue[0].ToLower() == "name")
                    {
                        sSearchProperties += ";Name=" + sValue;
                        chk.SearchProperties.Add(HtmlControl.PropertyNames.Name, sValue);
                    }
                    if (saKeyValue[0].ToLower() == "id")
                    {
                        sSearchProperties += ";Id=" + sValue;
                        chk.SearchProperties.Add(HtmlControl.PropertyNames.Id, sValue);
                    }
                    if (saKeyValue[0].ToLower() == "class")
                    {
                        sSearchProperties += ";Class=" + sValue;
                        chk.SearchProperties.Add(HtmlControl.PropertyNames.Class, sValue);
                    }
                }
            }

            if (sSearchProperties.Length > 1)
            {
                sSearchProperties = sSearchProperties.Substring(1);
            }
            CUITe_HtmlCheckBox retChk = new CUITe_HtmlCheckBox(sSearchProperties);
            retChk.Wrap(chk);
            return retChk;
        }

        /// <summary>
        /// Gets the column headers of the html table.
        /// </summary>
        /// <returns>string array</returns>
        public string[] GetColumnHeaders()
        {
            string[] retArray;
            UITestControlCollection rows = this._control.Rows;
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

        public CUITe_HtmlHeaderCell GetHeader(int iRow, int iCol)
        {
            this._control.WaitForControlReady();
            HtmlControl _htmlHeaderCell = null;
            int rowCount = -1;

            foreach (HtmlControl control in this._control.Rows)
            {
                if (control.ControlType != ControlType.RowHeader)
                {
                    continue;
                }

                rowCount++;
                if (rowCount == iRow)
                {
                    int colCount = -1;

                    foreach (HtmlControl cell in control.GetChildren()) //Cells could be a collection of HtmlCell and HtmlHeaderCell controls
                    {
                        if (!(cell is HtmlHeaderCell))
                        {
                            continue;
                        }

                        colCount++;
                        if (colCount == iCol)
                        {
                            _htmlHeaderCell = cell;
                            break;
                        }
                    }
                }
                if (_htmlHeaderCell != null)
                {
                    break;
                }
            }

            return new CUITe_HtmlHeaderCell(_htmlHeaderCell);
        }

        public CUITe_HtmlCell GetCell(int iRow, int iCol)
        {
            this._control.WaitForControlReady();
            HtmlControl _htmlCell = null;
            int rowCount = -1;

            UITestControlCollection coltemp = RemoveRowHeaders(this._control.Rows);

            foreach (HtmlRow cont in coltemp)
            {
                rowCount++;
                if (rowCount == iRow)
                {
                    int colCount = -1;
                    foreach (HtmlControl cell in cont.Cells) //Cells could be a collection of HtmlCell and HtmlHeaderCell controls
                    {
                        colCount++;
                        if (colCount == iCol)
                        {
                            _htmlCell = cell;
                            break;
                        }
                    }
                }
                if (_htmlCell != null)
                {
                    break;
                }
            }

            return new CUITe_HtmlCell(_htmlCell);
        }

        private mshtml.IHTMLElement GetEmbeddedCheckBoxNativeElement(mshtml.IHTMLElement parent)
        {
            while (true)
            {
                foreach (mshtml.IHTMLElement ele2 in parent.children)
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

        private UITestControlCollection RemoveRowHeaders(UITestControlCollection collection)
        {
            HtmlControl control = this._control.Rows[0] as HtmlControl;
            if ((control != null) && ((control.ControlType == ControlType.RowHeader)
                || !control.GetChildren().Any(x => string.Compare((x as HtmlControl).TagName, "td", true) == 0)))
            {
                collection.RemoveAt(0);
            }
            
            return collection;
        }
    }
}
