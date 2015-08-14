#if SILVERLIGHT_SUPPORT
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightCell.
    /// </summary>
    public class SilverlightCell : SilverlightControl<CUITControls.SilverlightCell>
    {
        public SilverlightCell() : base() { }
        public SilverlightCell(string searchParameters) : base(searchParameters) { }

        public bool Checked
        {
            get
            {
                _control.WaitForControlReady();
                return _control.Checked;
            }
            set
            {
                _control.WaitForControlReady();
                _control.Checked = value;
            }
        }

        public string ColumnHeader
        {
            get
            {
                _control.WaitForControlReady();
                return _control.ColumnHeader;
            }
        }

        /// <summary>
        /// Gets the 0-based index of the cell.
        /// </summary>
        public int ColumnIndex
        {
            get
            {
                _control.WaitForControlReady();
                return _control.ColumnIndex;
            }
        }

        /// <summary>
        /// Gets the 0-based index of the row.
        /// </summary>
        public int RowIndex
        {
            get
            {
                _control.WaitForControlReady();
                return _control.RowIndex;
            }
        }

        public bool Selected
        {
            get
            {
                _control.WaitForControlReady();
                return _control.Selected;
            }
        }

        public string Value
        {
            get
            {
                _control.WaitForControlReady();
                return _control.Value;
            }
            set
            {
                _control.WaitForControlReady();
                _control.Value = value;
            }
        }
    }
}
#endif