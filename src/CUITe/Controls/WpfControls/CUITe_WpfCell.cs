using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfCell
    /// </summary>
    public class CUITe_WpfCell : CUITe_WpfControl<WpfCell>
    {
        public CUITe_WpfCell() : base() { }
        public CUITe_WpfCell(string searchParameters) : base(searchParameters) { }
        
        public bool Checked
        {
            get { return this.UnWrap().Checked; }
            set { this.UnWrap().Checked = value; }
        }

        public int ColumnIndex
        {
            get { return this.UnWrap().ColumnIndex; }
        }

        public bool Indeterminate
        {
            get { return this.UnWrap().Indeterminate; }
            set { this.UnWrap().Indeterminate = value; }
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
            set { this.UnWrap().Value = value; }
        }

    }
}