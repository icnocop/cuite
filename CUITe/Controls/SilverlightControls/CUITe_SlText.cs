using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    public class CUITe_SlText : CUITe_ControlBase
    {
        private SilverlightText _SlText;

        public CUITe_SlText(string sSearchParameters) : base(sSearchParameters) { }

        public void Wrap(SilverlightText control)
        {
            base.Wrap(control);
            this._SlText = control;
        }

        public SilverlightText UnWrap()
        {
            return this._SlText;
        }
    }
}
