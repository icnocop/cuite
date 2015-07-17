using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfRow
    /// </summary>
    public class CUITe_WpfRow : CUITe_WpfControl<WpfRow>
    {
        public CUITe_WpfRow() : base() { }
        public CUITe_WpfRow(string searchParameters) : base(searchParameters) { }

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

        public UITestControl Header
        {
            get { return this.UnWrap().Header; }
        }

        public int RowIndex
        {
            get { return this.UnWrap().RowIndex; }
        }

        public bool Selected
        {
            get { return this.UnWrap().Selected; }
        }
    }
}