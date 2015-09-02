using System.Collections.Generic;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfRow
    /// </summary>
    public class WpfRow : WpfControl<CUITControls.WpfRow>
    {
        public WpfRow(By searchConfiguration = null)
            : this(new CUITControls.WpfRow(), searchConfiguration)
        {
        }

        public WpfRow(CUITControls.WpfRow sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
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

        public UITestControl Header
        {
            get { return SourceControl.Header; }
        }

        public int RowIndex
        {
            get { return SourceControl.RowIndex; }
        }

        public bool Selected
        {
            get { return SourceControl.Selected; }
        }
    }
}