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

        public CUITe_SlCheckBox() : base() { }
        public CUITe_SlCheckBox(string sSearchParameters) : base(sSearchParameters) { }

        public void Wrap(SilverlightCheckBox control)
        {
            base.Wrap(control);
            this._SlCheckBox = control;
        }

        /// <summary>
        /// Helps you wrap a SilverlightCheckBox control with a CUITe_SlCheckBox to leverage CUITe's convenient methods.
        /// </summary>
        /// <param name="control"></param>
        /// <example>
        /// <code>
        /// CUITe_SlCheckBox chkEdit = new CUITe_SlCheckBox();
        /// chkEdit.WrapReady(edit);
        /// chkEdit.Check();
        /// </code>
        /// Here 'edit' is a SilverlightCheckBox object.
        /// </example>
        public void WrapReady(SilverlightCheckBox control)
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
