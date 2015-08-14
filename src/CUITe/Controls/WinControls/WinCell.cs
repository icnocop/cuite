using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinCell
    /// </summary>
    public class WinCell : WinControl<CUITControls.WinCell>
    {
        public WinCell() : base() { }
        public WinCell(string searchParameters) : base(searchParameters) { }

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