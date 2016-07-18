using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// Represents a table control to test the user interface (UI) of a Silverlight application.
    /// </summary>
    public class SilverlightTable : SilverlightControl<CUITControls.SilverlightTable>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightTable" /> class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightTable(UITestControl parent, By searchConfiguration = null)
            : this(new CUITControls.SilverlightTable(parent), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightTable"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightTable(CUITControls.SilverlightTable sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the number of rows in the table.
        /// </summary>
        public int RowCount
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.RowCount;
            }
        }

        /// <summary>
        /// Finds a row by using specified <paramref name="valueToSearch"/> and clicks its column
        /// specified by <paramref name="columnIndex"/>.
        /// </summary>
        /// <param name="valueToSearch">The value to search.</param>
        /// <param name="columnIndex">Index of the column.</param>
        /// <param name="searchOptions">The search options.</param>
        public void FindRowAndClick(
            string valueToSearch,
            int columnIndex,
            SilverlightTableSearchOptions searchOptions = SilverlightTableSearchOptions.Normal)
        {
            int rowIndex = FindRowIndex(valueToSearch, columnIndex, searchOptions);
            Click(rowIndex, columnIndex);
        }

        /// <summary>
        /// Finds a row by using specified <paramref name="valueToSearch"/> and double-clicks its
        /// column specified by <paramref name="columnIndex"/>.
        /// </summary>
        /// <param name="valueToSearch">The value to search.</param>
        /// <param name="columnIndex">Index of the column.</param>
        /// <param name="searchOptions">The search options.</param>
        public void FindRowAndDoubleClick(
            string valueToSearch,
            int columnIndex,
            SilverlightTableSearchOptions searchOptions)
        {
            int rowIndex = FindRowIndex(valueToSearch, columnIndex, searchOptions);
            DoubleClick(rowIndex, columnIndex);
        }

        /// <summary>
        /// Clicks on cell with specified row and column index.
        /// </summary>
        /// <param name="rowIndex">Index of the row.</param>
        /// <param name="columnIndex">Index of the column.</param>
        public void Click(int rowIndex, int columnIndex)
        {
            Mouse.Click(GetCell(rowIndex, columnIndex));
        }

        /// <summary>
        /// Double-clicks on cell with specified row and column index.
        /// </summary>
        /// <param name="rowIndex">Index of the row.</param>
        /// <param name="columnIndex">Index of the column.</param>
        public void DoubleClick(int rowIndex, int columnIndex)
        {
            Mouse.DoubleClick(GetCell(rowIndex, columnIndex));
        }

        /// <summary>
        /// Finds a row index by using specified <paramref name="valueToSearch"/> and
        /// <paramref name="columnIndex"/>.
        /// </summary>
        /// <param name="valueToSearch">The value to search.</param>
        /// <param name="columnIndex">Index of the column.</param>
        /// <param name="searchOptions">The search options.</param>
        public int FindRowIndex(
            string valueToSearch,
            int columnIndex,
            SilverlightTableSearchOptions searchOptions)
        {
            WaitForControlReadyIfNecessary();

            int rowIndex = -1;
            int rowCount = -1;
            foreach (CUITControls.SilverlightRow cont in SourceControl.Rows)
            {
                rowCount++;
                int columnCount = -1;
                foreach (CUITControls.SilverlightCell cell in cont.Cells)
                {
                    columnCount++;
                    bool searchOptionResult = false;
                    if (columnCount == columnIndex)
                    {
                        if (searchOptions == SilverlightTableSearchOptions.Normal)
                        {
                            searchOptionResult = (valueToSearch == cell.Value);
                        }
                        else if (searchOptions == SilverlightTableSearchOptions.NormalTight)
                        {
                            searchOptionResult = (valueToSearch == cell.Value.Trim());
                        }
                        else if (searchOptions == SilverlightTableSearchOptions.StartsWith)
                        {
                            searchOptionResult = cell.Value.StartsWith(valueToSearch);
                        }
                        else if (searchOptions == SilverlightTableSearchOptions.EndsWith)
                        {
                            searchOptionResult = cell.Value.EndsWith(valueToSearch);
                        }
                        else if (searchOptions == SilverlightTableSearchOptions.Greedy)
                        {
                            searchOptionResult = (cell.Value.IndexOf(valueToSearch) > -1);
                        }
                        if (searchOptionResult)
                        {
                            rowIndex = rowCount;
                            break;
                        }
                    }
                }
                if (rowIndex > -1)
                    break;
            }
            return rowIndex;
        }

        /// <summary>
        /// Gets the value of the cell with specified row and column index.
        /// </summary>
        /// <param name="rowIndex">Index of the row.</param>
        /// <param name="columnIndex">Index of the column.</param>
        /// <returns>The value of the cell with specified row and column index.</returns>
        public string GetCellValue(int rowIndex, int columnIndex)
        {
            CUITControls.SilverlightCell cell = GetCell(rowIndex, columnIndex);
            return cell != null ? cell.Value : string.Empty;
        }

        /// <summary>
        /// Gets the checkbox in the row header of specified row index.
        /// </summary>
        /// <param name="rowIndex">Index of the row.</param>
        /// <returns>The checkbox in the row header of specified row index.</returns>
        public SilverlightCheckBox GetRowHeaderCheckBox(int rowIndex)
        {
            var checkbox = (CUITControls.SilverlightCheckBox)SourceControl.Rows[rowIndex].GetChildren()[0].GetChildren()[0];
            return new SilverlightCheckBox(checkbox, By.SearchProperties("*"));
        }

        private CUITControls.SilverlightCell GetCell(int rowIndex, int columnIndex)
        {
            WaitForControlReadyIfNecessary();
            CUITControls.SilverlightCell _SlCell = null;
            int rowCount = -1;
            foreach (CUITControls.SilverlightRow cont in SourceControl.Rows)
            {
                rowCount++;
                if (rowCount == rowIndex)
                {
                    int colCount = -1;
                    foreach (CUITControls.SilverlightCell cell in cont.Cells)
                    {
                        colCount++;
                        if (colCount == columnIndex)
                        {
                            _SlCell = cell;
                            break;
                        }
                    }
                }
                if (_SlCell != null)
                {
                    break;
                }
            }
            return _SlCell;
        }
    }
}
