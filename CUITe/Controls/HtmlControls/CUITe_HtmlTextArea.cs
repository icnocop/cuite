using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlTextArea : CUITe_ControlBase
    {
        private HtmlTextArea _htmlTextArea;

        public CUITe_HtmlTextArea(string sSearchParameters) : base(sSearchParameters) { }

        public void Wrap(HtmlTextArea control)
        {
            base.Wrap(control);
            this._htmlTextArea = control;
        }

        public HtmlTextArea UnWrap()
        {
            return this._htmlTextArea;
        }

        public void SetText(string sText)
        {
            this._htmlTextArea.WaitForControlReady();
            this._htmlTextArea.Text = sText;
        }

        public string Text
        {
            get 
            {
                this._htmlTextArea.WaitForControlReady();
                return this._htmlTextArea.Text; 
            }
        }

        public bool ReadOnly
        {
            get
            {
                this._htmlTextArea.WaitForControlReady();
                return this._htmlTextArea.ReadOnly;
            }
        }
    }
}
