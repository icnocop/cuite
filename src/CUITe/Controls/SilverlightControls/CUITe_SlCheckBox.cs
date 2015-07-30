using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightCheckBox.
    /// </summary>
    public class CUITe_SlCheckBox : CUITe_SlControl<SilverlightCheckBox>
    {
        public CUITe_SlCheckBox() : base() { }
        public CUITe_SlCheckBox(string searchParameters) : base(searchParameters) { }

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
