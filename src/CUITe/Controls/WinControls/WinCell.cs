using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Represents a cell control to test the user interface (UI) of Windows Forms.
    /// </summary>
    public class WinCell : WinControl<CUITControls.WinCell>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinCell"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinCell(By searchConfiguration = null)
            : this(new CUITControls.WinCell(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WinCell"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinCell(CUITControls.WinCell sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets a value that indicates whether this control is checked.
        /// </summary>
        public bool Checked
        {
            get { return SourceControl.Checked; }
            set { SourceControl.Checked = value; }
        }

        /// <summary>
        /// Gets the index of the column for this cell control.
        /// </summary>
        public int ColumnIndex
        {
            get { return SourceControl.ColumnIndex; }
        }

        /// <summary>
        /// Gets or sets a value that indicates whether the state of this cell is indeterminate.
        /// </summary>
        public bool Indeterminate
        {
            get { return SourceControl.Indeterminate; }
            set { SourceControl.Indeterminate = value; }
        }

        /// <summary>
        /// Gets the index of the table row for this cell control.
        /// </summary>
        public int RowIndex
        {
            get { return SourceControl.RowIndex; }
        }

        /// <summary>
        /// Returns a value that indicates whether this cell is selected.
        /// </summary>
        public bool Selected
        {
            get { return SourceControl.Selected; }
        }

        /// <summary>
        /// Gets or sets the value in this cell control.
        /// </summary>
        public string Value
        {
            get { return SourceControl.Value; }
            set { SourceControl.Value = value; }
        }
    }
}