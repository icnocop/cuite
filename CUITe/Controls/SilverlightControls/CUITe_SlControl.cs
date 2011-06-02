using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    public class CUITe_SlControl : CUITe_ControlBase
    {
        private SilverlightControl _SlControl;

        public CUITe_SlControl(string sSearchParameters) : base(sSearchParameters) { }

        public void Wrap(SilverlightControl control)
        {
            base.Wrap(control);
            this._SlControl = control;
        }

        public SilverlightControl UnWrap()
        {
            return this._SlControl;
        }
    }
}
