using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinCheckBox
    /// </summary>
    public class WinCheckBox : WinControl<CUITControls.WinCheckBox>
    {
        public WinCheckBox()
        {
        }

        public WinCheckBox(string searchParameters)
            : base(searchParameters)
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