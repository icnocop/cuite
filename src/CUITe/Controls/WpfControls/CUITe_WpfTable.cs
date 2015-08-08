using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfTable
    /// </summary>
    public class CUITe_WpfTable : CUITe_WpfControl<WpfTable>
    {
        public CUITe_WpfTable() : base() { }
        public CUITe_WpfTable(string searchParameters) : base(searchParameters) { }

        public bool CanSelectMultiple
        {
            get { return this.UnWrap().CanSelectMultiple; }
        }

        public UITestControlCollection Cells
        {
            get { return this.UnWrap().Cells; }
        }

        public List<CUITe_WpfCell> CellsAsCUITe
        {
            get
            {
                List<CUITe_WpfCell> list = new List<CUITe_WpfCell>();
                foreach (WpfCell control in this.UnWrap().Cells)
                {
                    CUITe_WpfCell cell = new CUITe_WpfCell();
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

        public List<CUITe_WpfRow> RowsAsCUITe
        {
            get
            {
                List<CUITe_WpfRow> list = new List<CUITe_WpfRow>();
                foreach (WpfRow control in this.UnWrap().Rows)
                {
                    CUITe_WpfRow row = new CUITe_WpfRow();
                    row.WrapReady(control);
                    list.Add(row);
                }
                return list;
            }
        }

    }
}