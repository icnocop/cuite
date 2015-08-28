using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinCheckBox
    /// </summary>
    public class WinCheckBox : WinControl<CUITControls.WinCheckBox>
    {
        public WinCheckBox(string searchProperties = null)
            : this(new CUITControls.WinCheckBox(), searchProperties)
        {
        }

        public WinCheckBox(CUITControls.WinCheckBox sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }

        public bool Checked
        {
            get { return SourceControl.Checked; }
            set { SourceControl.Checked = value; }
        }

        public bool Indeterminate
        {
            get { return SourceControl.Indeterminate; }
            set { SourceControl.Indeterminate = value; }
        }
    }
}