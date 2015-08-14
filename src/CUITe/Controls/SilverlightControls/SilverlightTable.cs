#if SILVERLIGHT_SUPPORT
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightTable.
    /// </summary>
    public class SilverlightTable : SilverlightControl<CUITControls.SilverlightTable>
    {
        public SilverlightTable() { }
        public SilverlightTable(string searchParameters) : base(searchParameters) { }

        public int RowCount
        {
            get
            {
                _control.WaitForControlReady();
                return _control.RowCount;
            }
        }

        public void FindRowAndClick(int iCol, string sValueToSearch)
        {
            int iRow = FindRow(iCol, sValueToSearch, SilverlightTableSearchOptions.Normal);
            Mouse.Click(GetCell(iRow, iCol));
        }

        public void FindRowAndClick(int iCol, string sValueToSearch, SilverlightTableSearchOptions option)
        {
            int iRow = FindRow(iCol, sValueToSearch, option);
            Mouse.Click(GetCell(iRow, iCol));
        }

        public void FindRowAndDoubleClick(int iCol, string sValueToSearch)
        {
            int iRow = FindRow(iCol, sValueToSearch, SilverlightTableSearchOptions.Normal);
            Mouse.DoubleClick(GetCell(iRow, iCol));
        }

        public void FindRowAndDoubleClick(int iCol, string sValueToSearch, SilverlightTableSearchOptions option)
        {
            int iRow = FindRow(iCol, sValueToSearch, option);
            Mouse.DoubleClick(GetCell(iRow, iCol));
        }

        public void FindCellAndClick(int iRow, int iCol)
        {
            Mouse.Click(GetCell(iRow, iCol));
        }

        public void FindCellAndDoubleClick(int iRow, int iCol)
        {
            Mouse.DoubleClick(GetCell(iRow, iCol));
        }

        public int FindRow(int iCol, string sValueToSearch, SilverlightTableSearchOptions option)
        {
            _control.WaitForControlReady();
            int iRow = -1;
            int rowCount = -1;
            foreach (CUITControls.SilverlightRow cont in _control.Rows)
            {
                rowCount++;
                int colCount = -1;
                foreach (CUITControls.SilverlightCell cell in cont.Cells)
                {
                    colCount++;
                    bool bSearchOptionResult = false;
                    if (colCount == iCol)
                    {
                        if (option == SilverlightTableSearchOptions.Normal)
                        {
                            bSearchOptionResult = (sValueToSearch == cell.Value);
                        }
                        else if (option == SilverlightTableSearchOptions.NormalTight)
                        {
                            bSearchOptionResult = (sValueToSearch == cell.Value.Trim());
                        }
                        else if (option == SilverlightTableSearchOptions.StartsWith)
                        {
                            bSearchOptionResult = cell.Value.StartsWith(sValueToSearch);
                        }
                        else if (option == SilverlightTableSearchOptions.EndsWith)
                        {
                            bSearchOptionResult = cell.Value.EndsWith(sValueToSearch);
                        }
                        else if (option == SilverlightTableSearchOptions.Greedy)
                        {
                            bSearchOptionResult = (cell.Value.IndexOf(sValueToSearch) > -1);
                        }
                        if (bSearchOptionResult)
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
            string sResult = "";
            CUITControls.SilverlightCell _SlCell = GetCell(iRow, iCol);
            if (_SlCell != null) sResult = _SlCell.Value;
            return sResult;
        }

        private CUITControls.SilverlightCell GetCell(int iRow, int iCol)
        {
            _control.WaitForControlReady();
            CUITControls.SilverlightCell _SlCell = null;
            int rowCount = -1;
            foreach (CUITControls.SilverlightRow cont in _control.Rows)
            {
                rowCount++;
                if (rowCount == iRow)
                {
                    int colCount = -1;
                    foreach (CUITControls.SilverlightCell cell in cont.Cells)
                    {
                        colCount++;
                        if (colCount == iCol)
                        {
                            _SlCell = cell;
                            break;
                        }
                    }
                }
                if (_SlCell != null)
                {
                    break;
                }
            }
            return _SlCell;
        }

        public SilverlightCheckBox GetRowHeaderCheckBox(int iRow)
        {
            var _checkbox = (CUITControls.SilverlightCheckBox)_control.Rows[iRow].GetChildren()[0].GetChildren()[0];
            SilverlightCheckBox retObj = new SilverlightCheckBox("*");
            retObj.WrapReady(_checkbox);
            return retObj;
        }
    }
}
#endif