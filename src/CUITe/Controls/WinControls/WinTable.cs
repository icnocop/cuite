using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinTable
    /// </summary>
    public class WinTable : WinControl<CUITControls.WinTable>
    {
        public WinTable()
        {
        }

        public WinTable(string searchParameters)
            : base(searchParameters)
        {
        }

        public UITestControlCollection Cells
        {
            get { return UnWrap().Cells; }
        }

        public List<WinCell> CellsAsCUITe
        {
            get
            {
                List<WinCell> list = new List<WinCell>();
                foreach (CUITControls.WinCell control in UnWrap().Cells)
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
            get { return UnWrap().ColumnHeaders; }
        }

        public UITestControl HorizontalScrollBar
        {
            get { return UnWrap().HorizontalScrollBar; }
        }

        public UITestControlCollection RowHeaders
        {
            get { return UnWrap().RowHeaders; }
        }

        public UITestControlCollection Rows
        {
            get { return UnWrap().Rows; }
        }

        public List<WinRow> RowsAsCUITe
        {
            get
            {
                List<WinRow> list = new List<WinRow>();
                foreach (CUITControls.WinRow control in UnWrap().Rows)
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
            get { return UnWrap().VerticalScrollBar; }
        }
    }
}