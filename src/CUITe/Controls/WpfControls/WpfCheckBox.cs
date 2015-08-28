using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfCheckBox
    /// </summary>
    public class WpfCheckBox : WpfControl<CUITControls.WpfCheckBox>
    {
        public WpfCheckBox(string searchProperties = null)
            : this(new CUITControls.WpfCheckBox(), searchProperties)
        {
        }

        public WpfCheckBox(CUITControls.WpfCheckBox sourceControl, string searchProperties = null)
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