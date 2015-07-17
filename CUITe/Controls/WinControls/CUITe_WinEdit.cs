using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinEdit
    /// </summary>
    public class CUITe_WinEdit : CUITe_ControlBase<WinEdit>
    {
        public CUITe_WinEdit() : base() { }
        public CUITe_WinEdit(string searchParameters) : base(searchParameters) { }

        public string CopyPastedText
        {
            get { return this.UnWrap().CopyPastedText; }
            set { this.UnWrap().CopyPastedText = value; }
        }

        public int CurrentLine
        {
            get { return this.UnWrap().CurrentLine; }
        }

        public int InsertionIndexAbsolute
        {
            get { return this.UnWrap().InsertionIndexAbsolute; }
            set { this.UnWrap().InsertionIndexAbsolute = value; }
        }

        public int InsertionIndexLineRelative
        {
            get { return this.UnWrap().InsertionIndexLineRelative; }
        }
        
        public bool IsPassword
        {
            get { return this.UnWrap().IsPassword; }
        }

        public int LineCount
        {
            get { return this.UnWrap().LineCount; }
        }

        public int MaxLength
        {
            get { return this.UnWrap().MaxLength; }
        }

        public string Password
        {
            set { this.UnWrap().Password = value; }
        }
        
        public bool ReadOnly
        {
            get { return this.UnWrap().ReadOnly; }
        }

        public int SelectionEnd
        {
            get { return this.UnWrap().SelectionEnd; }
            set { this.UnWrap().SelectionEnd = value; }
        }

        public int SelectionStart
        {
            get { return this.UnWrap().SelectionStart; }
            set { this.UnWrap().SelectionStart = value; }
        }

        public string SelectionText
        {
            get { return this.UnWrap().SelectionText; }
            set { this.UnWrap().SelectionText = value; }
        }

        public string Text
        {
            get { return this.UnWrap().Text; }
            set { this.UnWrap().Text = value; }
        }
    }
}