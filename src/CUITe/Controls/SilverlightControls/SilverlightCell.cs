#if SILVERLIGHT_SUPPORT
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightCell.
    /// </summary>
    public class SilverlightCell : SilverlightControl<CUITControls.SilverlightCell>
    {
        public SilverlightCell()
        {
        }

        public SilverlightCell(string searchParameters)
            : base(searchParameters)
        {
        }

        public bool Checked
        {
            get
            {
                SourceControl.WaitForControlReady();
                return SourceControl.Checked;
            }
            set
            {
                SourceControl.WaitForControlReady();
                SourceControl.Checked = value;
            }
        }

        public string ColumnHeader
        {
            get
            {
                SourceControl.WaitForControlReady();
                return SourceControl.ColumnHeader;
            }
        }

        /// <summary>
        /// Gets the 0-based index of the cell.
        /// </summary>
        public int ColumnIndex
        {
            get
            {
                SourceControl.WaitForControlReady();
                return SourceControl.ColumnIndex;
            }
        }

        /// <summary>
        /// Gets the 0-based index of the row.
        /// </summary>
        public int RowIndex
        {
            get
            {
                SourceControl.WaitForControlReady();
                return SourceControl.RowIndex;
            }
        }

        public bool Selected
        {
            get
            {
                SourceControl.WaitForControlReady();
                return SourceControl.Selected;
            }
        }

        public string Value
        {
            get
            {
                SourceControl.WaitForControlReady();
                return SourceControl.Value;
            }
            set
            {
                SourceControl.WaitForControlReady();
                SourceControl.Value = value;
            }
        }
    }
}
#endif