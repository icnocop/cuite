using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Represents a combo box control to test the user interface (UI) of Windows Presentation
    /// Foundation (WPF) applications.
    /// </summary>
    public class WpfComboBox : WpfControl<CUITControls.WpfComboBox>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WpfComboBox"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfComboBox(By searchConfiguration = null)
            : this(new CUITControls.WpfComboBox(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WpfComboBox"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfComboBox(CUITControls.WpfComboBox sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets or sets the contents of the editable part of this combo box.
        /// </summary>
        public string EditableItem
        {
            get { return SourceControl.EditableItem; }
            set { SourceControl.EditableItem = value; }
        }

        /// <summary>
        /// Gets or sets a value that indicates whether the list part of this combo box is expanded.
        /// </summary>
        public bool Expanded
        {
            get { return SourceControl.Expanded; }
            set { SourceControl.Expanded = value; }
        }

        /// <summary>
        /// Gets a value that indicates whether this combo box is editable.
        /// </summary>
        public bool IsEditable
        {
            get { return SourceControl.IsEditable; }
        }

        /// <summary>
        /// Gets a collection of items in the list part of this combo box.
        /// </summary>
        // TODO: Wrap these into CUITe controls
        public UITestControlCollection Items
        {
            get { return SourceControl.Items; }
        }

        /// <summary>
        /// Gets or sets the index of the selected item in the list part of this combo box.
        /// </summary>
        public int SelectedIndex
        {
            get { return SourceControl.SelectedIndex; }
            set { SourceControl.SelectedIndex = value; }
        }

        /// <summary>
        /// Gets or sets the contents of the selected item in the list part of this combo box.
        /// </summary>
        public string SelectedItem
        {
            get { return SourceControl.SelectedItem; }
            set { SourceControl.SelectedItem = value; }
        }
    }
}