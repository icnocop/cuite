using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlCheckBox : CUITe_ControlBase
    {
        private HtmlCheckBox _htmlCheckBox;

        public CUITe_HtmlCheckBox() : base() { }        
        public CUITe_HtmlCheckBox(string sSearchParameters) : base(sSearchParameters) { }

        public void Wrap(HtmlCheckBox control)
        {
            base.Wrap(control);
            this._htmlCheckBox = control;
        }

        /// <summary>
        /// Helps you wrap a HtmlCheckBox control with a CUITe_HtmlCheckBox to leverage CUITe's convenient methods.
        /// </summary>
        /// <param name="control"></param>
        /// <example>
        /// <code>
        /// CUITe_HtmlCheckBox chkEdit = new CUITe_HtmlCheckBox();
        /// chkEdit.WrapReady(edit);
        /// chkEdit.Check();
        /// </code>
        /// Here 'edit' is a HtmlCheckBox object.
        /// </example>
        public void WrapReady(HtmlCheckBox control)
        {
            base.WrapReady(control);
            this._htmlCheckBox = control;
        }

        public HtmlCheckBox UnWrap()
        {
            return this._htmlCheckBox;
        }

        public void Check()
        {
            this._htmlCheckBox.WaitForControlReady();
            if (!this._htmlCheckBox.Checked)
            {
                this._htmlCheckBox.Checked = true;
            }
        }

        public void Check2()
        {
            this._htmlCheckBox.WaitForControlReady();
            string sOnClick = (string)this._htmlCheckBox.GetProperty("onclick");
            string sId = this._htmlCheckBox.Id;
            if (sId == null || sId == "")
            {
                throw new CUITe_GenericException("Check2(): No ID found for the checkbox!");
            }
            RunScript("document.getElementById('" + sId + "').checked=true;" + sOnClick);
        }

        public void UnCheck()
        {
            this._htmlCheckBox.WaitForControlReady();
            if (this._htmlCheckBox.Checked)
            {
                this._htmlCheckBox.Checked = false;
            }
        }

        public bool Checked
        {
            get 
            {
                this._htmlCheckBox.WaitForControlReady();
                return this._htmlCheckBox.Checked; 
            }
        }
    }
}
