using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Represents an edit control to test the user interface (UI) of Windows Forms.
    /// </summary>
    public class WinEdit : WinControl<CUITControls.WinEdit>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinEdit"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinEdit(By searchConfiguration = null)
            : this(new CUITControls.WinEdit(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WinEdit"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinEdit(CUITControls.WinEdit sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets or sets the text in the text box by using copy-paste.
        /// </summary>
        public string CopyPastedText
        {
            get { return SourceControl.CopyPastedText; }
            set { SourceControl.CopyPastedText = value; }
        }

        /// <summary>
        /// Gets the line number for the cursor position in a multiline edit control.
        /// </summary>
        public int CurrentLine
        {
            get { return SourceControl.CurrentLine; }
        }

        /// <summary>
        /// Gets or sets the character position of the caret that is relative to the first
        /// character in the control.
        /// </summary>
        public int InsertionIndexAbsolute
        {
            get { return SourceControl.InsertionIndexAbsolute; }
            set { SourceControl.InsertionIndexAbsolute = value; }
        }

        /// <summary>
        /// Gets the column number of the caret position in the line that contains the caret.
        /// </summary>
        public int InsertionIndexLineRelative
        {
            get { return SourceControl.InsertionIndexLineRelative; }
        }

        /// <summary>
        /// Gets a value that indicates whether this edit control contains a password.
        /// </summary>
        public bool IsPassword
        {
            get { return SourceControl.IsPassword; }
        }

        /// <summary>
        /// Gets the number of lines in this edit control.
        /// </summary>
        public int LineCount
        {
            get { return SourceControl.LineCount; }
        }

        /// <summary>
        /// Gets the maximum number of characters that can be typed into this edit control.
        /// </summary>
        public int MaxLength
        {
            get { return SourceControl.MaxLength; }
        }

        /// <summary>
        /// Sets the encrypted text of this edit control.
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
        /// Gets or sets the end point for selected text.
        /// </summary>
        public int SelectionEnd
        {
            get { return SourceControl.SelectionEnd; }
            set { SourceControl.SelectionEnd = value; }
        }

        /// <summary>
        /// Gets or sets the start point for selected text.
        /// </summary>
        public int SelectionStart
        {
            get { return SourceControl.SelectionStart; }
            set { SourceControl.SelectionStart = value; }
        }

        /// <summary>
        /// Gets or sets the content of the selected text.
        /// </summary>
        public string SelectionText
        {
            get { return SourceControl.SelectionText; }
            set { SourceControl.SelectionText = value; }
        }

        /// <summary>
        /// Gets or sets the text in this edit control.
        /// </summary>
        public string Text
        {
            get { return SourceControl.Text; }
            set { SourceControl.Text = value; }
        }
    }
}