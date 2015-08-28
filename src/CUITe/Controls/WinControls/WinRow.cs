using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinRow
    /// </summary>
    public class WinRow : WinControl<CUITControls.WinRow>
    {
        public WinRow(string searchProperties = null)
            : this(new CUITControls.WinRow(), searchProperties)
        {
        }

        public WinRow(CUITControls.WinRow sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
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

        public int RowIndex
        {
            get { return SourceControl.RowIndex; }
        }

        public bool Selected
        {
            get { return SourceControl.Selected; }
        }

        public string Value
        {
            get { return SourceControl.Value; }
        }
    }
}