using System.Collections.Generic;
using System.Linq;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Represents a table control to test the user interface (UI) of Windows Forms.
    /// </summary>
    public class WinTable : WinControl<CUITControls.WinTable>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinTable"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinTable(By searchConfiguration = null)
            : this(new CUITControls.WinTable(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WinTable"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinTable(CUITControls.WinTable sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets a collection of cells in this table.
        /// </summary>
        public IEnumerable<WinCell> Cells
        {
            get
            {
                return SourceControl.Cells
                    .Cast<CUITControls.WinCell>()
                    .Select(cell => new WinCell(cell))
                    .ToArray();
            }
        }

        /// <summary>
        /// Gets a collection of column header controls in this table control.
        /// </summary>
        // TODO: Wrap these into CUITe controls
        public UITestControlCollection ColumnHeaders
        {
            get { return SourceControl.ColumnHeaders; }
        }

        /// <summary>
        /// Gets the horizontal scroll bar control in this table control.
        /// </summary>
        public UITestControl HorizontalScrollBar
        {
            get { return SourceControl.HorizontalScrollBar; }
        }

        /// <summary>
        /// Gets a collection of row header controls in this table control.
        /// </summary>
        // TODO: Wrap these into CUITe controls
        public UITestControlCollection RowHeaders
        {
            get { return SourceControl.RowHeaders; }
        }

        /// <summary>
        /// Gets a collection of rows in this table control.
        /// </summary>
        public IEnumerable<WinRow> Rows
        {
            get
            {
                return SourceControl.Rows
                    .Cast<CUITControls.WinRow>()
                    .Select(row => new WinRow(row))
                    .ToArray();
            }
        }

        /// <summary>
        /// Gets the vertical scroll bar in this table control.
        /// </summary>
        // TODO: Wrap these into CUITe controls
        public UITestControl VerticalScrollBar
        {
            get { return SourceControl.VerticalScrollBar; }
        }
    }
}