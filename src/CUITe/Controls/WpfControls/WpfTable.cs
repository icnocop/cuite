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
        public WpfTable() { }
        public WpfTable(string searchParameters) : base(searchParameters) { }

        public bool CanSelectMultiple
        {
            get { return UnWrap().CanSelectMultiple; }
        }

        public UITestControlCollection Cells
        {
            get { return UnWrap().Cells; }
        }

        public List<WpfCell> CellsAsCUITe
        {
            get
            {
                List<WpfCell> list = new List<WpfCell>();
                foreach (CUITControls.WpfCell control in UnWrap().Cells)
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
            get { return UnWrap().ColumnCount; }
        }

        public UITestControlCollection ColumnHeaders
        {
            get { return UnWrap().ColumnHeaders; }
        }

        public int RowCount
        {
            get { return UnWrap().RowCount; }
        }

        public UITestControlCollection RowHeaders
        {
            get { return UnWrap().RowHeaders; }
        }

        public UITestControlCollection Rows
        {
            get { return UnWrap().Rows; }
        }

        public List<WpfRow> RowsAsCUITe
        {
            get
            {
                List<WpfRow> list = new List<WpfRow>();
                foreach (CUITControls.WpfRow control in UnWrap().Rows)
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