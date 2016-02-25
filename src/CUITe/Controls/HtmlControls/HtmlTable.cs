using CUITe.SearchConfigurations;
using mshtml;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    /// <summary>
    /// Represents a table control for Web page user interface (UI) testing.
    /// </summary>
    public class HtmlTable : HtmlControl<CUITControls.HtmlTable>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlTable"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlTable(By searchConfiguration = null)
            : this(new CUITControls.HtmlTable(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlTable"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlTable(CUITControls.HtmlTable sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the number of columns in this table.
        /// </summary>
        public int ColumnCount
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.ColumnCount;
            }
        }

        /// <summary>
        /// Gets the number of rows in this table.
        /// </summary>
        public int RowCount
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.Rows.Count;
            }
        }

        /// <summary>
        /// Finds a row by using specified <paramref name="valueToSearch"/> and clicks its column
        /// specified by <paramref name="columnIndex"/>.
        /// </summary>
        /// <param name="valueToSearch">The value to search.</param>
        /// <param name="columnIndex">Index of the column.</param>
        /// <param name="searchOptions">The search options.</param>
        public void FindRowAndClick(
            string valueToSearch,
            int columnIndex,
            HtmlTableSearchOptions searchOptions = HtmlTableSearchOptions.Normal)
        {
            int rowIndex = FindRowIndex(valueToSearch, columnIndex, searchOptions);
            FindCellAndClick(rowIndex, columnIndex);
        }
        
        /// <summary>
        /// Finds a row by using specified <paramref name="valueToSearch"/> and double-clicks its
        /// column specified by <paramref name="columnIndex"/>.
        /// </summary>
        /// <param name="valueToSearch">The value to search.</param>
        /// <param name="columnIndex">Index of the column.</param>
        /// <param name="searchOptions">The search options.</param>
        public void FindRowAndDoubleClick(
            string valueToSearch,
            int columnIndex,
            HtmlTableSearchOptions searchOptions = HtmlTableSearchOptions.Normal)
        {
            int rowIndex = FindRowIndex(valueToSearch, columnIndex, searchOptions);
            FindCellAndDoubleClick(rowIndex, columnIndex);
        }

        /// <summary>
        /// Finds the header cell by specified <paramref name="rowIndex"/> and
        /// <paramref name="columnIndex"/> and clicks it.
        /// </summary>
        /// <param name="rowIndex">Index of the row.</param>
        /// <param name="columnIndex">Index of the column.</param>
        public void FindHeaderCellAndClick(int rowIndex, int columnIndex)
        {
            GetHeaderCell(rowIndex, columnIndex).Click();
        }

        /// <summary>
        /// Finds the cell by specified <paramref name="rowIndex"/> and
        /// <paramref name="columnIndex"/> and clicks it.
        /// </summary>
        /// <param name="rowIndex">Index of the row.</param>
        /// <param name="columnIndex">Index of the column.</param>
        public void FindCellAndClick(int rowIndex, int columnIndex)
        {
            GetCell<HtmlControl<CUITControls.HtmlControl>>(rowIndex, columnIndex).Click();
        }

        /// <summary>
        /// Finds the cell by specified <paramref name="rowIndex"/> and
        /// <paramref name="columnIndex"/> and double-clicks it.
        /// </summary>
        /// <param name="rowIndex">Index of the row.</param>
        /// <param name="columnIndex">Index of the column.</param>
        public void FindCellAndDoubleClick(int rowIndex, int columnIndex)
        {
            GetCell(rowIndex, columnIndex).DoubleClick();
        }

        /// <summary>
        /// Finds a row index by using specified <paramref name="valueToSearch"/> and
        /// <paramref name="columnIndex"/>.
        /// </summary>
        /// <param name="valueToSearch">The value to search.</param>
        /// <param name="columnIndex">Index of the column.</param>
        /// <param name="searchOptions">The search options.</param>
        public int FindRowIndex(
            string valueToSearch,
            int columnIndex,
            HtmlTableSearchOptions searchOptions)
        {
            WaitForControlReadyIfNecessary();
            int iRow = -1;
            int rowCount = -1;

            foreach (CUITControls.HtmlControl control in SourceControl.Rows)
            {
                //control could be of ControlType.RowHeader or ControlType.Row

                rowCount++;

                int columnCount = -1;

                foreach (CUITControls.HtmlControl cell in control.GetChildren()) //Cells could be a collection of HtmlCell and HtmlHeaderCell controls
                {
                    columnCount++;
                    bool searchOptionResult = false;
                    if (columnCount == columnIndex)
                    {
                        if (searchOptions == HtmlTableSearchOptions.Normal)
                        {
                            searchOptionResult = (valueToSearch == cell.InnerText);
                        }
                        else if (searchOptions == HtmlTableSearchOptions.NormalTight)
                        {
                            searchOptionResult = (valueToSearch == cell.InnerText.Trim());
                        }
                        else if (searchOptions == HtmlTableSearchOptions.StartsWith)
                        {
                            searchOptionResult = cell.InnerText.StartsWith(valueToSearch);
                        }
                        else if (searchOptions == HtmlTableSearchOptions.EndsWith)
                        {
                            searchOptionResult = cell.InnerText.EndsWith(valueToSearch);
                        }
                        else if (searchOptions == HtmlTableSearchOptions.Greedy)
                        {
                            searchOptionResult = (cell.InnerText.IndexOf(valueToSearch) > -1);
                        }
                        if (searchOptionResult)
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

        /// <summary>
        /// Gets the value of the cell with specified row and column index.
        /// </summary>
        /// <param name="rowIndex">Index of the row.</param>
        /// <param name="columnIndex">Index of the column.</param>
        /// <returns>The value of the cell with specified row and column index.</returns>
        public string GetCellValue(int rowIndex, int columnIndex)
        {
            return GetCellValue<HtmlCell>(rowIndex, columnIndex);
        }

        /// <summary>
        /// Gets the value of the header cell with specified row and column index.
        /// </summary>
        /// <param name="rowIndex">Index of the row.</param>
        /// <param name="columnIndex">Index of the column.</param>
        /// <returns>The value of the cell with specified row and column index.</returns>
        public string GetHeaderCellValue(int rowIndex, int columnIndex)
        {
            return GetCellValue<HtmlHeaderCell>(rowIndex, columnIndex);
        }

        /// <summary>
        /// Gets the embedded check box at specified <paramref name="rowIndex"/> and
        /// <paramref name="columnIndex"/>.
        /// </summary>
        /// <param name="rowIndex">Index of the row.</param>
        /// <param name="columnIndex">Index of the column.</param>
        /// <returns></returns>
        public HtmlCheckBox GetEmbeddedCheckBox(int rowIndex, int columnIndex)
        {
            string sSearchProperties = "";
            var td = (IHTMLElement)GetCell(rowIndex, columnIndex).SourceControl.NativeElement;
            IHTMLElement check = GetEmbeddedCheckBoxNativeElement(td);
            string outerHtml = check.outerHTML.Replace("<", "").Replace(">", "").Trim();
            string[] saTemp = outerHtml.Split(' ');
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

            return new HtmlCheckBox(chk, By.SearchProperties(sSearchProperties));
        }

        /// <summary>
        /// Gets the column headers of the html table.
        /// </summary>
        public string[] GetColumnHeaders()
        {
            UITestControlCollection rows = SourceControl.Rows;

            if ((rows != null) && (rows.Count > 0))
            {
                if ((rows[0] != null) && (rows[0].ControlType == ControlType.RowHeader))
                {
                    var headers = rows[0].GetChildren();
                    var columnHeaders = new string[headers.Count];
                    for (int i = 0; i < columnHeaders.Length; i++)
                    {
                        columnHeaders[i] = (string)headers[i].GetProperty("Value");
                    }
                    return columnHeaders;
                }
            }

            return null;
        }

        /// <summary>
        /// Gets the header cell at specified <paramref name="rowIndex"/> and
        /// <paramref name="columnIndex"/>.
        /// </summary>
        /// <param name="rowIndex">Index of the row.</param>
        /// <param name="columnIndex">Index of the column.</param>
        public HtmlHeaderCell GetHeaderCell(int rowIndex, int columnIndex)
        {
            return GetCell<HtmlHeaderCell>(rowIndex, columnIndex);
        }

        /// <summary>
        /// Gets the cell at specified <paramref name="rowIndex"/> and
        /// <paramref name="columnIndex"/>.
        /// </summary>
        /// <param name="rowIndex">Index of the row.</param>
        /// <param name="columnIndex">Index of the column.</param>
        public HtmlCell GetCell(int rowIndex, int columnIndex)
        {
            return GetCell<HtmlCell>(rowIndex, columnIndex);
        }

        private string GetCellValue<T>(int iRow, int iCol) where T : ControlBase, IHasInnerText
        {
            string innerText = "";
            T htmlCell = GetCell<T>(iRow, iCol);
            if (htmlCell != null)
            {
                innerText = htmlCell.InnerText;
            }

            return innerText;
        }

        private T GetCell<T>(int iRow, int iCol) where T : ControlBase, IHasInnerText
        {
            WaitForControlReadyIfNecessary();
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

        private static IHTMLElement GetEmbeddedCheckBoxNativeElement(IHTMLElement parent)
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