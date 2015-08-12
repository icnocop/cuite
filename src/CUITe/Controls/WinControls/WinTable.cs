using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUIT = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinTable
    /// </summary>
    public class WinTable : WinControl<CUIT.WinTable>
    {
        public WinTable() : base() { }
        public WinTable(string searchParameters) : base(searchParameters) { }

        public UITestControlCollection Cells
        {
            get { return this.UnWrap().Cells; }
        }

        public List<WinCell> CellsAsCUITe
        {
            get
            {
                List<WinCell> list = new List<WinCell>();
                foreach (CUIT.WinCell control in this.UnWrap().Cells)
                {
                    WinCell cell = new WinCell();
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

        public List<WinRow> RowsAsCUITe
        {
            get
            {
                List<WinRow> list = new List<WinRow>();
                foreach (CUIT.WinRow control in this.UnWrap().Rows)
                {
                    WinRow row = new WinRow();
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