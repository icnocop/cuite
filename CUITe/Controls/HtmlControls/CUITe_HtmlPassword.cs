using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlPassword : CUITe_ControlBase
    {
        private HtmlEdit _htmlPassword;

        public CUITe_HtmlPassword(string sSearchParameters) : base(sSearchParameters) { }

        public void Wrap(HtmlEdit control)
        {
            base.Wrap(control);
            this._htmlPassword = control;
            this._htmlPassword.FilterProperties[HtmlEdit.PropertyNames.Type] = "PASSWORD";
        }

        public HtmlEdit UnWrap()
        {
            return this._htmlPassword;
        }

        public void SetText(string sText)
        {
            this._htmlPassword.WaitForControlReady();
            this._htmlPassword.Text = sText;
        }

        public string GetText()
        {
            this._htmlPassword.WaitForControlReady();
            return this._htmlPassword.Text;
        }

        public bool ReadOnly
        {
            get
            {
                this._htmlPassword.WaitForControlReady();
                return this._htmlPassword.ReadOnly;
            }
        }
    }
}
