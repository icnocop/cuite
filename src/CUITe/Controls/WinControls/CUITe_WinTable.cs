using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinTable
    /// </summary>
    public class CUITe_WinTable : CUITe_WinControl<WinTable>
    {
        public CUITe_WinTable() : base() { }
        public CUITe_WinTable(string searchParameters) : base(searchParameters) { }

        public UITestControlCollection Cells
        {
            get { return this.UnWrap().Cells; }
        }

        public List<CUITe_WinCell> CellsAsCUITe
        {
            get
            {
                List<CUITe_WinCell> list = new List<CUITe_WinCell>();
                foreach (WinCell control in this.UnWrap().Cells)
                {
                    CUITe_WinCell cell = new CUITe_WinCell();
                    cell.WrapReady(control);
                    list.Add(cell);
                }
                return list;
            }
        }

        public UITestControlCollection ColumnHeaders
        {
            get { return this.UnWrap().ColumnHeaders; }
        }

        public UITestControl HorizontalScrollBar
        {
            get { return this.UnWrap().HorizontalScrollBar; }
        }

        public UITestControlCollection RowHeaders
        {
            get { return this.UnWrap().RowHeaders; }
        }

        public UITestControlCollection Rows
        {
            get { return this.UnWrap().Rows; }
        }

        public List<CUITe_WinRow> RowsAsCUITe
        {
            get
            {
                List<CUITe_WinRow> list = new List<CUITe_WinRow>();
                foreach (WinRow control in this.UnWrap().Rows)
                {
                    CUITe_WinRow row = new CUITe_WinRow();
                    row.WrapReady(control);
                    list.Add(row);
                }
                return list;
            }
        }

        public UITestControl VerticalScrollBar
        {
            get { return this.UnWrap().VerticalScrollBar; }
        }
    }
}