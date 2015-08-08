using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfEdit
    /// </summary>
    public class CUITe_WpfEdit : CUITe_WpfControl<WpfEdit>
    {
        public CUITe_WpfEdit() : base() { }
        public CUITe_WpfEdit(string searchParameters) : base(searchParameters) { }

        public string CopyPastedText
        {
            get { return this.UnWrap().CopyPastedText; }
            set { this.UnWrap().CopyPastedText = value; }
        }

        public bool IsPassword
        {
            get { return this.UnWrap().IsPassword; }
        }

        public string Password
        {
            set { this.UnWrap().Password = value; }
        }

        public bool ReadOnly
        {
            get { return this.UnWrap().ReadOnly; }
        }

        public string SelectionText
        {
            get { return this.UnWrap().SelectionText; }
        }

        public string Text
        {
            get { return this.UnWrap().Text; }
            set { this.UnWrap().Text = value; }
        }
    }
}