using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfCell
    /// </summary>
    public class WpfCell : WpfControl<CUITControls.WpfCell>
    {
        public WpfCell(string searchProperties = null)
            : this(new CUITControls.WpfCell(), searchProperties)
        {
        }

        public WpfCell(CUITControls.WpfCell sourceControl, string searchProperties = null)
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