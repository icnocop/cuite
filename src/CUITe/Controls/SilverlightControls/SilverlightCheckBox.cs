#if SILVERLIGHT_SUPPORT
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightCheckBox.
    /// </summary>
    public class SilverlightCheckBox : SilverlightControl<CUITControls.SilverlightCheckBox>
    {
        public SilverlightCheckBox(string searchProperties = null)
            : this(new CUITControls.SilverlightCheckBox(), searchProperties)
        {
        }

        public SilverlightCheckBox(CUITControls.SilverlightCheckBox sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
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