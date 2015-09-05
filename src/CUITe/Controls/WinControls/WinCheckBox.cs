using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinCheckBox
    /// </summary>
    public class WinCheckBox : WinControl<CUITControls.WinCheckBox>
    {
        public WinCheckBox(By searchConfiguration = null)
            : this(new CUITControls.WinCheckBox(), searchConfiguration)
        {
        }

        public WinCheckBox(CUITControls.WinCheckBox sourceControl, By searchConfiguration = null)
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