using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfRow
    /// </summary>
    public class WpfRow : WpfControl<CUITControls.WpfRow>
    {
        public WpfRow() : base() { }
        public WpfRow(string searchParameters) : base(searchParameters) { }

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