using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfEdit
    /// </summary>
    public class WpfEdit : WpfControl<CUITControls.WpfEdit>
    {
        public WpfEdit(By searchConfiguration = null)
            : this(new CUITControls.WpfEdit(), searchConfiguration)
        {
        }

        public WpfEdit(CUITControls.WpfEdit sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
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