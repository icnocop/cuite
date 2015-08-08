using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfCheckBox
    /// </summary>
    public class CUITe_WpfCheckBox : CUITe_WpfControl<WpfCheckBox>
    {
        public CUITe_WpfCheckBox() : base() { }
        public CUITe_WpfCheckBox(string searchParameters) : base(searchParameters) { }

        public bool Checked
        {
            get { return this.UnWrap().Checked; }
            set { this.UnWrap().Checked = value; }
        }

        public bool Indeterminate
        {
            get { return this.UnWrap().Indeterminate; }
            set { this.UnWrap().Indeterminate = value; }
        }

    }
}