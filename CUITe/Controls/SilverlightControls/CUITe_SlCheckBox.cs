using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    public class CUITe_SlCheckBox : CUITe_ControlBase
    {
        private SilverlightCheckBox _SlCheckBox;

        public CUITe_SlCheckBox(string sSearchParameters) : base(sSearchParameters) { }

        public void Wrap(SilverlightCheckBox control)
        {
            base.Wrap(control);
            this._SlCheckBox = control;
        }

        internal void WrapReady(SilverlightCheckBox control)
        {
            base.WrapReady(control);
            this._SlCheckBox = control;
        }

        public SilverlightCheckBox UnWrap()
        {
            return this._SlCheckBox;
        }

        public void Check()
        {
            this._SlCheckBox.WaitForControlReady();
            if (!this._SlCheckBox.Checked)
            {
                this._SlCheckBox.Checked = true;
            }
        }

        public void UnCheck()
        {
            this._SlCheckBox.WaitForControlReady();
            if (this._SlCheckBox.Checked)
            {
                this._SlCheckBox.Checked = false;
            }
        }

        public bool Checked
        {
            get
            {
                this._SlCheckBox.WaitForControlReady();
                return this._SlCheckBox.Checked;
            }
        }
    }
}
