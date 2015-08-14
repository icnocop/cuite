using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfCheckBox
    /// </summary>
    public class WpfCheckBox : WpfControl<CUITControls.WpfCheckBox>
    {
        public WpfCheckBox() : base() { }
        public WpfCheckBox(string searchParameters) : base(searchParameters) { }

        public bool Checked
        {
            get { return UnWrap().Checked; }
            set { UnWrap().Checked = value; }
        }

        public bool Indeterminate
        {
            get { return UnWrap().Indeterminate; }
            set { UnWrap().Indeterminate = value; }
        }

    }
}