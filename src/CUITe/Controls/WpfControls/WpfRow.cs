using System.Collections.Generic;
using System.Linq;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Represents a table row control to test the user interface (UI) of Windows Presentation
    /// Foundation (WPF) applications.
    /// </summary>
    public class WpfRow : WpfControl<CUITControls.WpfRow>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WpfRow"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfRow(By searchConfiguration = null)
            : this(new CUITControls.WpfRow(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WpfRow"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfRow(CUITControls.WpfRow sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets a value that indicates whether the row can have multiple cells selected.
        /// </summary>
        public bool CanSelectMultiple
        {
            get { return SourceControl.CanSelectMultiple; }
        }

        /// <summary>
        /// Gets a collection of the cells in this table row.
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
        /// Gets the header for this table row.
        /// </summary>
        public UITestControl Header
        {
            get { return SourceControl.Header; }
        }

        /// <summary>
        /// Gets the index of this row in the table.
        /// </summary>
        public int RowIndex
        {
            get { return SourceControl.RowIndex; }
        }

        /// <summary>
        /// Gets a value that indicates whether this row can be selected.
        /// </summary>
        public bool Selected
        {
            get { return SourceControl.Selected; }
        }
    }
}