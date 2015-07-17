using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightCell.
    /// </summary>
    public class CUITe_SlCell : CUITe_SlControl<SilverlightCell>
    {
        public CUITe_SlCell() : base() { }
        public CUITe_SlCell(string searchParameters) : base(searchParameters) { }

        public bool Checked
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.Checked;
            }
            set
            {
                this._control.WaitForControlReady();
                this._control.Checked = value;
            }
        }

        public string ColumnHeader
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.ColumnHeader;
            }
        }

        /// <summary>
        /// Gets the 0-based index of the cell.
        /// </summary>
        public int ColumnIndex
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.ColumnIndex;
            }
        }

        /// <summary>
        /// Gets the 0-based index of the row.
        /// </summary>
        public int RowIndex
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.RowIndex;
            }
        }

        public bool Selected
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.Selected;
            }
        }

        public string Value
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.Value;
            }
            set
            {
                this._control.WaitForControlReady();
                this._control.Value = value;
            }
        }
    }
}
