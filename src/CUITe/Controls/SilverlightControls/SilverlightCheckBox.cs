#if SILVERLIGHT_SUPPORT
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightCheckBox.
    /// </summary>
    public class SilverlightCheckBox : SilverlightControl<CUITControls.SilverlightCheckBox>
    {
        public SilverlightCheckBox() { }
        public SilverlightCheckBox(string searchParameters) : base(searchParameters) { }

        public void Check()
        {
            _control.WaitForControlReady();
            if (!_control.Checked)
            {
                _control.Checked = true;
            }
        }

        public void UnCheck()
        {
            _control.WaitForControlReady();
            if (_control.Checked)
            {
                _control.Checked = false;
            }
        }

        public bool Checked
        {
            get
            {
                _control.WaitForControlReady();
                return _control.Checked;
            }
        }
    }
}
#endif