using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfCell
    /// </summary>
    public class WpfCell : WpfControl<CUITControls.WpfCell>
    {
        public WpfCell() { }
        public WpfCell(string searchParameters) : base(searchParameters) { }
        
        public bool Checked
        {
            get { return UnWrap().Checked; }
            set { UnWrap().Checked = value; }
        }

        public int ColumnIndex
        {
            get { return UnWrap().ColumnIndex; }
        }

        public bool Indeterminate
        {
            get { return UnWrap().Indeterminate; }
            set { UnWrap().Indeterminate = value; }
        }

        public int RowIndex
        {
            get { return UnWrap().RowIndex; }
        }

        public bool Selected
        {
            get { return UnWrap().Selected; }
        }

        public string Value
        {
            get { return UnWrap().Value; }
            set { UnWrap().Value = value; }
        }

    }
}