#if SILVERLIGHT_SUPPORT
using CUIT = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightCheckBox.
    /// </summary>
    public class SilverlightCheckBox : SilverlightControl<CUIT.SilverlightCheckBox>
    {
        public SilverlightCheckBox() : base() { }
        public SilverlightCheckBox(string searchParameters) : base(searchParameters) { }

        public void Check()
        {
            this._control.WaitForControlReady();
            if (!this._control.Checked)
            {
                this._control.Checked = true;
            }
        }

        public void UnCheck()
        {
            this._control.WaitForControlReady();
            if (this._control.Checked)
            {
                this._control.Checked = false;
            }
        }

        public bool Checked
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.Checked;
            }
        }
    }
}
#endif