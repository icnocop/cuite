using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    public class CUITe_SlEdit : CUITe_ControlBase<SilverlightEdit>
    {
        public CUITe_SlEdit() : base() { }
        public CUITe_SlEdit(string sSearchParameters) : base(sSearchParameters) { }

        public void SetText(string sText)
        {
            this._control.WaitForControlReady();
            this._control.Text = sText;
        }

        public string GetText()
        {
            this._control.WaitForControlReady();
            return this._control.Text;  
        }

        public bool ReadOnly
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.ReadOnly;
            }
        }
    }
}
