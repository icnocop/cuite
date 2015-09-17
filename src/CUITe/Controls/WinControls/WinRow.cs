using System.Collections.Generic;
using System.Linq;
using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Represents a table row control to test the user interface (UI) of Windows Forms.
    /// </summary>
    public class WinRow : WinControl<CUITControls.WinRow>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinRow"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinRow(By searchConfiguration = null)
            : this(new CUITControls.WinRow(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WinRow"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinRow(CUITControls.WinRow sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the collection of cells in this table row.
        /// </summary>
        public IEnumerable<WinCell> Cells
        {
            get
            {
                return SourceControl.Cells
                    .Cast<CUITControls.WinCell>()
                    .Select(item => new WinCell(item))
                    .ToArray();
            }
        }

        /// <summary>
        /// Gets the index of this row in the table.
        /// </summary>
        public int RowIndex
        {
            get { return SourceControl.RowIndex; }
        }

        /// <summary>
        /// Gets a value that indicates whether this table row is selected.
        /// </summary>
        public bool Selected
        {
            get { return SourceControl.Selected; }
        }

        /// <summary>
        /// Gets the value in this table row.
        /// </summary>
        public string Value
        {
            get { return SourceControl.Value; }
        }
    }
}