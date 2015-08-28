using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinCell
    /// </summary>
    public class WinCell : WinControl<CUITControls.WinCell>
    {
        public WinCell(string searchProperties = null)
            : this(new CUITControls.WinCell(), searchProperties)
        {
        }

        public WinCell(CUITControls.WinCell sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }

        public bool Checked
        {
            get { return SourceControl.Checked; }
            set { SourceControl.Checked = value; }
        }

        public int ColumnIndex
        {
            get { return SourceControl.ColumnIndex; }
        }

        public bool Indeterminate
        {
            get { return SourceControl.Indeterminate; }
            set { SourceControl.Indeterminate = value; }
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
            set { SourceControl.Value = value; }
        }
    }
}