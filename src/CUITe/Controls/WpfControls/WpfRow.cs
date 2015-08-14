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

        public UITestControl Header
        {
            get { return UnWrap().Header; }
        }

        public int RowIndex
        {
            get { return UnWrap().RowIndex; }
        }

        public bool Selected
        {
            get { return UnWrap().Selected; }
        }
    }
}