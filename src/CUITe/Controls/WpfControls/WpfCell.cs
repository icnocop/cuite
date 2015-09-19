using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Represents a table cell control to test the user interface (UI) of Windows Presentation
    /// Foundation (WPF) applications.
    /// </summary>
    public class WpfCell : WpfControl<CUITControls.WpfCell>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WpfCell"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfCell(By searchConfiguration = null)
            : this(new CUITControls.WpfCell(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WpfCell"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfCell(CUITControls.WpfCell sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets or sets a value that indicates whether this table cell is checked.
        /// </summary>
        public bool Checked
        {
            get { return SourceControl.Checked; }
            set { SourceControl.Checked = value; }
        }

        /// <summary>
        /// Gets the index of the table column for this cell control.
        /// </summary>
        public int ColumnIndex
        {
            get { return SourceControl.ColumnIndex; }
        }

        /// <summary>
        /// Gets or sets the indeterminate state of this cell control.
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
        /// Gets a value that indicates whether this cell is selected.
        /// </summary>
        public bool Selected
        {
            get { return SourceControl.Selected; }
        }

        /// <summary>
        /// Gets or sets the value of this cell as a string.
        /// </summary>
        public string Value
        {
            get { return SourceControl.Value; }
            set { SourceControl.Value = value; }
        }
    }
}