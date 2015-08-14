using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfEdit
    /// </summary>
    public class WpfEdit : WpfControl<CUITControls.WpfEdit>
    {
        public WpfEdit()
        {
        }

        public WpfEdit(string searchParameters)
            : base(searchParameters)
        {
        }

        public string CopyPastedText
        {
            get { return UnWrap().CopyPastedText; }
            set { UnWrap().CopyPastedText = value; }
        }

        public bool IsPassword
        {
            get { return UnWrap().IsPassword; }
        }

        public string Password
        {
            set { UnWrap().Password = value; }
        }

        public bool ReadOnly
        {
            get { return UnWrap().ReadOnly; }
        }

        public string SelectionText
        {
            get { return UnWrap().SelectionText; }
        }

        public string Text
        {
            get { return UnWrap().Text; }
            set { UnWrap().Text = value; }
        }
    }
}