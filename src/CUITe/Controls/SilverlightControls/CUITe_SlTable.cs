using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    public enum CUITe_SlTableSearchOptions
    {
        Normal,
        NormalTight,
        Greedy,
        StartsWith,
        EndsWith
    }

    /// <summary>
    /// CUITe wrapper for SilverlightTable.
    /// </summary>
    public class CUITe_SlTable : CUITe_SlControl<SilverlightTable>
    {
        public CUITe_SlTable() : base() { }
        public CUITe_SlTable(string searchParameters) : base(searchParameters) { }

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
            int iRow = FindRow(iCol, sValueToSearch, CUITe_SlTableSearchOptions.Normal);
            Mouse.Click(this.GetCell(iRow, iCol));
        }

        public void FindRowAndClick(int iCol, string sValueToSearch, CUITe_SlTableSearchOptions option)
        {
            int iRow = FindRow(iCol, sValueToSearch, option);
            Mouse.Click(this.GetCell(iRow, iCol));
        }

        public void FindRowAndDoubleClick(int iCol, string sValueToSearch)
        {
            int iRow = FindRow(iCol, sValueToSearch, CUITe_SlTableSearchOptions.Normal);
            Mouse.DoubleClick(this.GetCell(iRow, iCol));
        }

        public void FindRowAndDoubleClick(int iCol, string sValueToSearch, CUITe_SlTableSearchOptions option)
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

        public int FindRow(int iCol, string sValueToSearch, CUITe_SlTableSearchOptions option)
        {
            this._control.WaitForControlReady();
            int iRow = -1;
            int rowCount = -1;
            foreach (SilverlightRow cont in this._control.Rows)
            {
                rowCount++;
                int colCount = -1;
                foreach (SilverlightCell cell in cont.Cells)
                {
                    colCount++;
                    bool bSearchOptionResult = false;
                    if (colCount == iCol)
                    {
                        if (option == CUITe_SlTableSearchOptions.Normal)
                        {
                            bSearchOptionResult = (sValueToSearch == cell.Value);
                        }
                        else if (option == CUITe_SlTableSearchOptions.NormalTight)
                        {
                            bSearchOptionResult = (sValueToSearch == cell.Value.Trim());
                        }
                        else if (option == CUITe_SlTableSearchOptions.StartsWith)
                        {
                            bSearchOptionResult = cell.Value.StartsWith(sValueToSearch);
                        }
                        else if (option == CUITe_SlTableSearchOptions.EndsWith)
                        {
                            bSearchOptionResult = cell.Value.EndsWith(sValueToSearch);
                        }
                        else if (option == CUITe_SlTableSearchOptions.Greedy)
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
            SilverlightCell _SlCell = this.GetCell(iRow, iCol);
            if (_SlCell != null) sResult = _SlCell.Value;
            return sResult;
        }

        private SilverlightCell GetCell(int iRow, int iCol)
        {
            this._control.WaitForControlReady();
            SilverlightCell _SlCell = null;
            int rowCount = -1;
            foreach (SilverlightRow cont in this._control.Rows)
            {
                rowCount++;
                if (rowCount == iRow)
                {
                    int colCount = -1;
                    foreach (SilverlightCell cell in cont.Cells)
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

        public CUITe_SlCheckBox GetRowHeaderCheckBox(int iRow)
        {
            SilverlightCheckBox _checkbox = (SilverlightCheckBox)this._control.Rows[iRow].GetChildren()[0].GetChildren()[0];
            CUITe_SlCheckBox retObj = new CUITe_SlCheckBox("*");
            retObj.WrapReady(_checkbox);
            return retObj;
        }
    }
}
