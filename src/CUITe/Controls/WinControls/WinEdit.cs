using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinEdit
    /// </summary>
    public class WinEdit : ControlBase<CUITControls.WinEdit>
    {
        public WinEdit() { }
        public WinEdit(string searchParameters) : base(searchParameters) { }

        public string CopyPastedText
        {
            get { return UnWrap().CopyPastedText; }
            set { UnWrap().CopyPastedText = value; }
        }

        public int CurrentLine
        {
            get { return UnWrap().CurrentLine; }
        }

        public int InsertionIndexAbsolute
        {
            get { return UnWrap().InsertionIndexAbsolute; }
            set { UnWrap().InsertionIndexAbsolute = value; }
        }

        public int InsertionIndexLineRelative
        {
            get { return UnWrap().InsertionIndexLineRelative; }
        }
        
        public bool IsPassword
        {
            get { return UnWrap().IsPassword; }
        }

        public int LineCount
        {
            get { return UnWrap().LineCount; }
        }

        public int MaxLength
        {
            get { return UnWrap().MaxLength; }
        }

        public string Password
        {
            set { UnWrap().Password = value; }
        }
        
        public bool ReadOnly
        {
            get { return UnWrap().ReadOnly; }
        }

        public int SelectionEnd
        {
            get { return UnWrap().SelectionEnd; }
            set { UnWrap().SelectionEnd = value; }
        }

        public int SelectionStart
        {
            get { return UnWrap().SelectionStart; }
            set { UnWrap().SelectionStart = value; }
        }

        public string SelectionText
        {
            get { return UnWrap().SelectionText; }
            set { UnWrap().SelectionText = value; }
        }

        public string Text
        {
            get { return UnWrap().Text; }
            set { UnWrap().Text = value; }
        }
    }
}