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
            get { return _control.Checked; }
            set { _control.Checked = value; }
        }

        public bool Indeterminate
        {
            get { return _control.Indeterminate; }
            set { _control.Indeterminate = value; }
        }
    }
}