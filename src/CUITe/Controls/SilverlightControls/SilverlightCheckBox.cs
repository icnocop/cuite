using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

#if SILVERLIGHT_SUPPORT
namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightCheckBox.
    /// </summary>
    public class SilverlightCheckBox : SilverlightControl<CUITControls.SilverlightCheckBox>
    {
        public SilverlightCheckBox(By searchConfiguration = null)
            : this(new CUITControls.SilverlightCheckBox(), searchConfiguration)
        {
        }

        public SilverlightCheckBox(CUITControls.SilverlightCheckBox sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        public void Check()
        {
            WaitForControlReady();
            if (!SourceControl.Checked)
            {
                SourceControl.Checked = true;
            }
        }

        public void UnCheck()
        {
            WaitForControlReady();
            if (SourceControl.Checked)
            {
                SourceControl.Checked = false;
            }
        }

        public bool Checked
        {
            get
            {
                WaitForControlReady();
                return SourceControl.Checked;
            }
        }
    }
}
#endif