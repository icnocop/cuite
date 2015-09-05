using System.Collections.Generic;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinTable
    /// </summary>
    public class WinTable : WinControl<CUITControls.WinTable>
    {
        public WinTable(By searchConfiguration = null)
            : this(new CUITControls.WinTable(), searchConfiguration)
        {
        }

        public WinTable(CUITControls.WinTable sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        public UITestControlCollection Cells
        {
            get { return SourceControl.Cells; }
        }

        public List<WinCell> CellsAsCUITe
        {
            get
            {
                List<WinCell> list = new List<WinCell>();
                foreach (CUITControls.WinCell control in SourceControl.Cells)
                {
                    WinCell cell = new WinCell(control);
                    list.Add(cell);
                }
                return list;
            }
        }

        public UITestControlCollection ColumnHeaders
        {
            get { return SourceControl.ColumnHeaders; }
        }

        public UITestControl HorizontalScrollBar
        {
            get { return SourceControl.HorizontalScrollBar; }
        }

        public UITestControlCollection RowHeaders
        {
            get { return SourceControl.RowHeaders; }
        }

        public UITestControlCollection Rows
        {
            get { return SourceControl.Rows; }
        }

        public List<WinRow> RowsAsCUITe
        {
            get
            {
                List<WinRow> list = new List<WinRow>();
                foreach (CUITControls.WinRow control in SourceControl.Rows)
                {
                    WinRow row = new WinRow(control);
                    list.Add(row);
                }
                return list;
            }
        }

        public UITestControl VerticalScrollBar
        {
            get { return SourceControl.VerticalScrollBar; }
        }
    }
}