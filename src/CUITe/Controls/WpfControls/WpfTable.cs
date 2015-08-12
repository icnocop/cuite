using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfTable
    /// </summary>
    public class WpfTable : WpfControl<CUITControls.WpfTable>
    {
        public WpfTable() : base() { }
        public WpfTable(string searchParameters) : base(searchParameters) { }

        public bool CanSelectMultiple
        {
            get { return this.UnWrap().CanSelectMultiple; }
        }

        public UITestControlCollection Cells
        {
            get { return this.UnWrap().Cells; }
        }

        public List<WpfCell> CellsAsCUITe
        {
            get
            {
                List<WpfCell> list = new List<WpfCell>();
                foreach (CUITControls.WpfCell control in this.UnWrap().Cells)
                {
                    WpfCell cell = new WpfCell();
                    cell.WrapReady(control);
                    list.Add(cell);
                }
                return list;
            }
        }

        public int ColumnCount
        {
            get { return this.UnWrap().ColumnCount; }
        }

        public UITestControlCollection ColumnHeaders
        {
            get { return this.UnWrap().ColumnHeaders; }
        }

        public int RowCount
        {
            get { return this.UnWrap().RowCount; }
        }

        public UITestControlCollection RowHeaders
        {
            get { return this.UnWrap().RowHeaders; }
        }

        public UITestControlCollection Rows
        {
            get { return this.UnWrap().Rows; }
        }

        public List<WpfRow> RowsAsCUITe
        {
            get
            {
                List<WpfRow> list = new List<WpfRow>();
                foreach (CUITControls.WpfRow control in this.UnWrap().Rows)
                {
                    WpfRow row = new WpfRow();
                    row.WrapReady(control);
                    list.Add(row);
                }
                return list;
            }
        }

    }
}