#if SILVERLIGHT_SUPPORT
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightCheckBox.
    /// </summary>
    public class SilverlightCheckBox : SilverlightControl<CUITControls.SilverlightCheckBox>
    {
        public SilverlightCheckBox()
        {
        }

        public SilverlightCheckBox(string searchParameters)
            : base(searchParameters)
        {
        }

        public void Check()
        {
            SourceControl.WaitForControlReady();
            if (!SourceControl.Checked)
            {
                SourceControl.Checked = true;
            }
        }

        public void UnCheck()
        {
            SourceControl.WaitForControlReady();
            if (SourceControl.Checked)
            {
                SourceControl.Checked = false;
            }
        }

        public bool Checked
        {
            get
            {
                SourceControl.WaitForControlReady();
                return SourceControl.Checked;
            }
        }
    }
}
#endif