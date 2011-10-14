using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    public class CUITe_SlControl<T> : CUITe_ControlBase<T> where T : SilverlightControl
    {
        public CUITe_SlControl() : base() { }
        public CUITe_SlControl(string sSearchParameters) : base(sSearchParameters) { }

        public string LabeledBy
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.LabeledBy;
            }
        }
    }
}
