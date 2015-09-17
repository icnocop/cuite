using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Represents a combo box control to test the user interface (UI) of Windows Forms.
    /// </summary>
    public class WinComboBox : WinControl<CUITControls.WinComboBox>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinComboBox"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinComboBox(By searchConfiguration = null)
            : this(new CUITControls.WinComboBox(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WinComboBox"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinComboBox(CUITControls.WinComboBox sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets or sets the name of the editable part of this combo box control.
        /// </summary>
        public string EditableItem
        {
            get { return SourceControl.EditableItem; }
            set { SourceControl.EditableItem = value; }
        }

        /// <summary>
        /// Gets or sets a value that indicates whether the combo box control is expanded.
        /// </summary>
        public bool Expanded
        {
            get { return SourceControl.Expanded; }
            set { SourceControl.Expanded = value; }
        }

        /// <summary>
        /// Gets a value that indicates whether this combo box control is editable.
        /// </summary>
        public bool IsEditable
        {
            get { return SourceControl.IsEditable; }
        }

        /// <summary>
        /// Gets a collection of the items in the combo box control.
        /// </summary>
        // TODO: Wrap these into CUITe controls
        public UITestControlCollection Items
        {
            get { return SourceControl.Items; }
        }

        /// <summary>
        /// Gets or sets the index in the <see cref="Items"/> of the selected item.
        /// </summary>
        public int SelectedIndex
        {
            get { return SourceControl.SelectedIndex; }
            set { SourceControl.SelectedIndex = value; }
        }

        /// <summary>
        /// Gets or sets the selected item in this combo box control.
        /// </summary>
        public string SelectedItem
        {
            get { return SourceControl.SelectedItem; }
            set { SourceControl.SelectedItem = value; }
        }
    }
}