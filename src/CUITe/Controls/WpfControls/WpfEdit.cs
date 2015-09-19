using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Represents an edit control to test the user interface (UI) of Windows Presentation
    /// Foundation (WPF) applications.
    /// </summary>
    public class WpfEdit : WpfControl<CUITControls.WpfEdit>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WpfEdit"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfEdit(By searchConfiguration = null)
            : this(new CUITControls.WpfEdit(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WpfEdit"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfEdit(CUITControls.WpfEdit sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets or sets the contents of this edit control by using copy-paste.
        /// </summary>
        public string CopyPastedText
        {
            get { return SourceControl.CopyPastedText; }
            set { SourceControl.CopyPastedText = value; }
        }

        /// <summary>
        /// Gets a value that indicates whether the contents of this edit control is encrypted.
        /// </summary>
        public bool IsPassword
        {
            get { return SourceControl.IsPassword; }
        }

        /// <summary>
        /// Sets the encrypted password from this edit control.
        /// </summary>
        public string Password
        {
            set { SourceControl.Password = value; }
        }

        /// <summary>
        /// Gets a value that indicates whether this edit control is read-only.
        /// </summary>
        public bool ReadOnly
        {
            get { return SourceControl.ReadOnly; }
        }

        /// <summary>
        /// Gets the selected text from the contents of this edit control.
        /// </summary>
        public string SelectionText
        {
            get { return SourceControl.SelectionText; }
        }

        /// <summary>
        /// Gets or sets the contents of this edit control.
        /// </summary>
        public string Text
        {
            get { return SourceControl.Text; }
            set { SourceControl.Text = value; }
        }
    }
}