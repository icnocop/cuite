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
        public WinRow() : base() { }
        public WinRow(string searchParameters) : base(searchParameters) { }

        public UITestControlCollection Cells
        {
            get { return this.UnWrap().Cells; }
        }

        public List<WinCell> CellsAsCUITe
        {
            get
            {
                List<WinCell> list = new List<WinCell>();
                foreach (CUITControls.WinCell control in this.UnWrap().Cells)
                {
                    WinCell cell = new WinCell();
                    cell.WrapReady(control);
                    list.Add(cell);
                }
                return list;
            }
        }

        public int RowIndex
        {
            get { return this.UnWrap().RowIndex; }
        }

        public bool Selected
        {
            get { return this.UnWrap().Selected; }
        }

        public string Value
        {
            get { return this.UnWrap().Value; }
        }
    }
}