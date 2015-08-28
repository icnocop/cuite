using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfEdit
    /// </summary>
    public class WpfEdit : WpfControl<CUITControls.WpfEdit>
    {
        public WpfEdit(CUITControls.WpfEdit sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.WpfEdit(), searchProperties)
        {
        }

        public string CopyPastedText
        {
            get { return SourceControl.CopyPastedText; }
            set { SourceControl.CopyPastedText = value; }
        }

        public bool IsPassword
        {
            get { return SourceControl.IsPassword; }
        }

        public string Password
        {
            set { SourceControl.Password = value; }
        }

        public bool ReadOnly
        {
            get { return SourceControl.ReadOnly; }
        }

        public string SelectionText
        {
            get { return SourceControl.SelectionText; }
        }

        public string Text
        {
            get { return SourceControl.Text; }
            set { SourceControl.Text = value; }
        }
    }
}