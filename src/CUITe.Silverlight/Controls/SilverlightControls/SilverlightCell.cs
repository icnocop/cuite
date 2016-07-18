using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// Represents a cell control to test the user interface (UI) of a Silverlight application.
    /// </summary>
    public class SilverlightCell : SilverlightControl<CUITControls.SilverlightCell>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightCell" /> class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightCell(UITestControl parent, By searchConfiguration = null)
            : this(new CUITControls.SilverlightCell(parent), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightCell"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightCell(CUITControls.SilverlightCell sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets or sets a value that indicates whether the cell is checked.
        /// </summary>
        public bool Checked
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.Checked;
            }
            set
            {
                WaitForControlReadyIfNecessary();
                SourceControl.Checked = value;
            }
        }

        /// <summary>
        /// Gets the column header for the cell.
        /// </summary>
        public string ColumnHeader
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.ColumnHeader;
            }
        }

        /// <summary>
        /// Gets the column index of the cell.
        /// </summary>
        public int ColumnIndex
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.ColumnIndex;
            }
        }

        /// <summary>
        /// Gets the row index of the cell.
        /// </summary>
        public int RowIndex
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.RowIndex;
            }
        }

        /// <summary>
        /// Gets a value that indicates whether the cell is selected.
        /// </summary>
        public bool Selected
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.Selected;
            }
        }

        /// <summary>
        /// Gets or sets the value of the cell.
        /// </summary>
        public string Value
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.Value;
            }
            set
            {
                WaitForControlReadyIfNecessary();
                SourceControl.Value = value;
            }
        }
    }
}
