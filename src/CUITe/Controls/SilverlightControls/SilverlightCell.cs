#if SILVERLIGHT_SUPPORT
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightCell.
    /// </summary>
    public class SilverlightCell : SilverlightControl<CUITControls.SilverlightCell>
    {
        public SilverlightCell(CUITControls.SilverlightCell sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.SilverlightCell(), searchProperties)
        {
        }

        public bool Checked
        {
            get
            {
                WaitForControlReady();
                return SourceControl.Checked;
            }
            set
            {
                WaitForControlReady();
                SourceControl.Checked = value;
            }
        }

        public string ColumnHeader
        {
            get
            {
                WaitForControlReady();
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
                WaitForControlReady();
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
                WaitForControlReady();
                return SourceControl.RowIndex;
            }
        }

        public bool Selected
        {
            get
            {
                WaitForControlReady();
                return SourceControl.Selected;
            }
        }

        public string Value
        {
            get
            {
                WaitForControlReady();
                return SourceControl.Value;
            }
            set
            {
                WaitForControlReady();
                SourceControl.Value = value;
            }
        }
    }
}
#endif