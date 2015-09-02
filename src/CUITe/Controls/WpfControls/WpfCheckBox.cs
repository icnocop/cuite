using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfCheckBox
    /// </summary>
    public class WpfCheckBox : WpfControl<CUITControls.WpfCheckBox>
    {
        public WpfCheckBox(By searchConfiguration = null)
            : this(new CUITControls.WpfCheckBox(), searchConfiguration)
        {
        }

        public WpfCheckBox(CUITControls.WpfCheckBox sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
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