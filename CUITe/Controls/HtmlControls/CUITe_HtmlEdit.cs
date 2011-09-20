using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlEdit : CUITe_ControlBase
    {
        private HtmlEdit _htmlEdit;

        public CUITe_HtmlEdit() : base() { }
        public CUITe_HtmlEdit(string sSearchParameters) : base(sSearchParameters) { }

        public void Wrap(HtmlEdit control)
        {
            base.Wrap(control);
            this._htmlEdit = control;
        }

        /// <summary>
        /// Helps you wrap a HtmlEdit control with a CUITe_HtmlEdit to leverage CUITe's convenient methods.
        /// </summary>
        /// <param name="control"></param>
        /// <example>
        /// <code>
        /// CUITe_HtmlEdit txtEdit = new CUITe_HtmlEdit();
        /// txtEdit.WrapReady(edit);
        /// txtEdit.SetText("Coded UI Test enhanced Framework");
        /// </code>
        /// Here 'edit' is a HtmlEdit object.
        /// </example>
        public void WrapReady(HtmlEdit control)
        {
            base.WrapReady(control);
            this._htmlEdit = control;
        }

        public HtmlEdit UnWrap()
        {
            return this._htmlEdit;
        }

        public void SetText(string sText)
        {
            this._htmlEdit.WaitForControlReady();
            this._htmlEdit.Text = sText;
        }

        public string GetText()
        {
            this._htmlEdit.WaitForControlReady();
            return this._htmlEdit.Text; 
        }

        public bool ReadOnly
        {
            get
            {
                this._htmlEdit.WaitForControlReady();
                return this._htmlEdit.ReadOnly;
            }
        }
    }
}
