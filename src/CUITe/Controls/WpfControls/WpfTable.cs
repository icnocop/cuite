using System.Collections.Generic;
using System.Linq;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Represents a button control to test the user interface (UI) of Windows Presentation
    /// Foundation (WPF) applications.
    /// </summary>
    public class WpfTable : WpfControl<CUITControls.WpfTable>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WpfTable"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfTable(By searchConfiguration = null)
            : this(new CUITControls.WpfTable(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WpfTable"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfTable(CUITControls.WpfTable sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets a value that indicates whether this table can have multiple selections.
        /// </summary>
        public bool CanSelectMultiple
        {
            get { return SourceControl.CanSelectMultiple; }
        }

        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<WpfCell> Cells
        {
            get
            {
                return SourceControl.Cells
                    .Cast<CUITControls.WpfCell>()
                    .Select(cell => new WpfCell(cell))
                    .ToArray();
            }
        }

        /// <summary>
        /// Gets the number of columns in this table.
        /// </summary>
        public int ColumnCount
        {
            get { return SourceControl.ColumnCount; }
        }

        /// <summary>
        /// Gets a collection of column headers in this table.
        /// </summary>
        // TODO: Wrap these into CUITe controls
        public UITestControlCollection ColumnHeaders
        {
            get { return SourceControl.ColumnHeaders; }
        }

        /// <summary>
        /// Gets the number of rows in this table.
        /// </summary>
        public int RowCount
        {
            get { return SourceControl.RowCount; }
        }

        /// <summary>
        /// Gets a collection of row headers in this table.
        /// </summary>
        // TODO: Wrap these into CUITe controls
        public UITestControlCollection RowHeaders
        {
            get { return SourceControl.RowHeaders; }
        }

        /// <summary>
        /// Gets a collection of rows in this table.
        /// </summary>
        public IEnumerable<WpfRow> Rows
        {
            get
            {
                return SourceControl.Rows
                    .Cast<CUITControls.WpfRow>()
                    .Select(row => new WpfRow(row))
                    .ToArray();
            }
        }
    }
}