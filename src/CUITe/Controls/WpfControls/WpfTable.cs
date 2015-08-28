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
        public WpfTable(string searchProperties = null)
            : this(new CUITControls.WpfTable(), searchProperties)
        {
        }

        public WpfTable(CUITControls.WpfTable sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }

        public bool CanSelectMultiple
        {
            get { return SourceControl.CanSelectMultiple; }
        }

        public UITestControlCollection Cells
        {
            get { return SourceControl.Cells; }
        }

        public List<WpfCell> CellsAsCUITe
        {
            get
            {
                List<WpfCell> list = new List<WpfCell>();
                foreach (CUITControls.WpfCell control in SourceControl.Cells)
                {
                    WpfCell cell = new WpfCell(control);
                    list.Add(cell);
                }
                return list;
            }
        }

        public int ColumnCount
        {
            get { return SourceControl.ColumnCount; }
        }

        public UITestControlCollection ColumnHeaders
        {
            get { return SourceControl.ColumnHeaders; }
        }

        public int RowCount
        {
            get { return SourceControl.RowCount; }
        }

        public UITestControlCollection RowHeaders
        {
            get { return SourceControl.RowHeaders; }
        }

        public UITestControlCollection Rows
        {
            get { return SourceControl.Rows; }
        }

        public List<WpfRow> RowsAsCUITe
        {
            get
            {
                List<WpfRow> list = new List<WpfRow>();
                foreach (CUITControls.WpfRow control in SourceControl.Rows)
                {
                    WpfRow row = new WpfRow(control);
                    list.Add(row);
                }
                return list;
            }
        }
    }
}