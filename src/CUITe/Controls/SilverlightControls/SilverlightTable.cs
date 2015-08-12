#if SILVERLIGHT_SUPPORT
using Microsoft.VisualStudio.TestTools.UITesting;
using CUIT = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightTable.
    /// </summary>
    public class SilverlightTable : SilverlightControl<CUIT.SilverlightTable>
    {
        public SilverlightTable() : base() { }
        public SilverlightTable(string searchParameters) : base(searchParameters) { }

        public int RowCount
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.RowCount;
            }
        }

        public void FindRowAndClick(int iCol, string sValueToSearch)
        {
            int iRow = FindRow(iCol, sValueToSearch, SilverlightTableSearchOptions.Normal);
            Mouse.Click(this.GetCell(iRow, iCol));
        }

        public void FindRowAndClick(int iCol, string sValueToSearch, SilverlightTableSearchOptions option)
        {
            int iRow = FindRow(iCol, sValueToSearch, option);
            Mouse.Click(this.GetCell(iRow, iCol));
        }

        public void FindRowAndDoubleClick(int iCol, string sValueToSearch)
        {
            int iRow = FindRow(iCol, sValueToSearch, SilverlightTableSearchOptions.Normal);
            Mouse.DoubleClick(this.GetCell(iRow, iCol));
        }

        public void FindRowAndDoubleClick(int iCol, string sValueToSearch, SilverlightTableSearchOptions option)
        {
            int iRow = FindRow(iCol, sValueToSearch, option);
            Mouse.DoubleClick(this.GetCell(iRow, iCol));
        }

        public void FindCellAndClick(int iRow, int iCol)
        {
            Mouse.Click(this.GetCell(iRow, iCol));
        }

        public void FindCellAndDoubleClick(int iRow, int iCol)
        {
            Mouse.DoubleClick(this.GetCell(iRow, iCol));
        }

        public int FindRow(int iCol, string sValueToSearch, SilverlightTableSearchOptions option)
        {
            this._control.WaitForControlReady();
            int iRow = -1;
            int rowCount = -1;
            foreach (CUIT.SilverlightRow cont in this._control.Rows)
            {
                rowCount++;
                int colCount = -1;
                foreach (CUIT.SilverlightCell cell in cont.Cells)
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
            string sResult = "";
            CUIT.SilverlightCell _SlCell = this.GetCell(iRow, iCol);
            if (_SlCell != null) sResult = _SlCell.Value;
            return sResult;
        }

        private CUIT.SilverlightCell GetCell(int iRow, int iCol)
        {
            this._control.WaitForControlReady();
            CUIT.SilverlightCell _SlCell = null;
            int rowCount = -1;
            foreach (CUIT.SilverlightRow cont in this._control.Rows)
            {
                rowCount++;
                if (rowCount == iRow)
                {
                    int colCount = -1;
                    foreach (CUIT.SilverlightCell cell in cont.Cells)
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
            CUIT.SilverlightCheckBox _checkbox = (CUIT.SilverlightCheckBox)this._control.Rows[iRow].GetChildren()[0].GetChildren()[0];
            SilverlightCheckBox retObj = new SilverlightCheckBox("*");
            retObj.WrapReady(_checkbox);
            return retObj;
        }
    }
}
#endif