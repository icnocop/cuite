using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinEdit
    /// </summary>
    public class WinEdit : WinControl<CUITControls.WinEdit>
    {
        public WinEdit(By searchConfiguration = null)
            : this(new CUITControls.WinEdit(), searchConfiguration)
        {
        }

        public WinEdit(CUITControls.WinEdit sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        public string CopyPastedText
        {
            get { return SourceControl.CopyPastedText; }
            set { SourceControl.CopyPastedText = value; }
        }

        public int CurrentLine
        {
            get { return SourceControl.CurrentLine; }
        }

        public int InsertionIndexAbsolute
        {
            get { return SourceControl.InsertionIndexAbsolute; }
            set { SourceControl.InsertionIndexAbsolute = value; }
        }

        public int InsertionIndexLineRelative
        {
            get { return SourceControl.InsertionIndexLineRelative; }
        }

        public bool IsPassword
        {
            get { return SourceControl.IsPassword; }
        }

        public int LineCount
        {
            get { return SourceControl.LineCount; }
        }

        public int MaxLength
        {
            get { return SourceControl.MaxLength; }
        }

        public string Password
        {
            set { SourceControl.Password = value; }
        }

        public bool ReadOnly
        {
            get { return SourceControl.ReadOnly; }
        }

        public int SelectionEnd
        {
            get { return SourceControl.SelectionEnd; }
            set { SourceControl.SelectionEnd = value; }
        }

        public int SelectionStart
        {
            get { return SourceControl.SelectionStart; }
            set { SourceControl.SelectionStart = value; }
        }

        public string SelectionText
        {
            get { return SourceControl.SelectionText; }
            set { SourceControl.SelectionText = value; }
        }

        public string Text
        {
            get { return SourceControl.Text; }
            set { SourceControl.Text = value; }
        }
    }
}