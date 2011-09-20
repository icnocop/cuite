using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlRadioButton : CUITe_ControlBase
    {
        private HtmlRadioButton _htmlRadioButton;

        public CUITe_HtmlRadioButton(string sSearchParameters) : base(sSearchParameters) { }

        public void Wrap(HtmlRadioButton control)
        {
            base.Wrap(control);
            this._htmlRadioButton = control;
        }

        /// <summary>
        /// Helps you wrap a HtmlRadioButton control with a CUITe_HtmlRadioButton to leverage CUITe's convenient methods.
        /// </summary>
        /// <param name="control"></param>
        /// <example>
        /// <code>
        /// CUITe_HtmlRadioButton radEdit = new CUITe_HtmlRadioButton();
        /// radEdit.WrapReady(edit);
        /// radEdit.Select();
        /// </code>
        /// Here 'edit' is a HtmlRadioButton object.
        /// </example>
        public void WrapReady(HtmlRadioButton control)
        {
            base.WrapReady(control);
            this._htmlRadioButton = control;
        }

        public HtmlRadioButton UnWrap()
        {
            return this._htmlRadioButton;
        }

        public void Select()
        {
            this._htmlRadioButton.WaitForControlReady();
            this._htmlRadioButton.Selected = true;
        }

        public void Select2()
        {
            this._htmlRadioButton.WaitForControlReady();
            string sOnClick = (string)this._htmlRadioButton.GetProperty("onclick");
            string sId = this._htmlRadioButton.Id;
            if (sId == null || sId == "")
            {
                throw new CUITe_GenericException("Select2(): No ID found for the RadioButton!");
            }
            RunScript("document.getElementById('" + sId + "').checked=true;" + sOnClick);
        }

        public bool IsSelected
        {
            get {
                this._htmlRadioButton.WaitForControlReady();
                return this._htmlRadioButton.Selected; 
            }
        }
    }
}
