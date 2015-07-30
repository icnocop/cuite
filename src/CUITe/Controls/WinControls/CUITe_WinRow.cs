using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinRow
    /// </summary>
    public class CUITe_WinRow : CUITe_WinControl<WinRow>
    {
        public CUITe_WinRow() : base() { }
        public CUITe_WinRow(string searchParameters) : base(searchParameters) { }

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