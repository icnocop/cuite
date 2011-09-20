using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    public class CUITe_SlEdit : CUITe_ControlBase
    {
        private SilverlightEdit _SlEdit;

        public CUITe_SlEdit(string sSearchParameters) : base(sSearchParameters) { }

        public void Wrap(SilverlightEdit control)
        {
            base.Wrap(control);
            this._SlEdit = control;
        }

        /// <summary>
        /// Helps you wrap a SilverlightEdit control with a CUITe_SlEdit to leverage CUITe's convenient methods.
        /// </summary>
        /// <param name="control"></param>
        /// <example>
        /// <code>
        /// CUITe_SlEdit txtEdit = new CUITe_SlEdit();
        /// txtEdit.WrapReady(edit);
        /// txtEdit.SetText("Coded UI Test enhanced Framework");
        /// </code>
        /// Here 'edit' is a SilverlightEdit object.
        /// </example>
        public void WrapReady(SilverlightEdit control)
        {
            base.WrapReady(control);
            this._SlEdit = control;
        }

        public SilverlightEdit UnWrap()
        {
            return this._SlEdit;
        }

        public void SetText(string sText)
        {
            this._SlEdit.WaitForControlReady();
            this._SlEdit.Text = sText;
        }

        public string GetText()
        {
            this._SlEdit.WaitForControlReady();
            return this._SlEdit.Text;  
        }

        public bool ReadOnly
        {
            get
            {
                this._SlEdit.WaitForControlReady();
                return this._SlEdit.ReadOnly;
            }
        }
    }
}
