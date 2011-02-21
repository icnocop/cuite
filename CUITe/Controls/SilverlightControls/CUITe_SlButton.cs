using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    public class CUITe_SlButton: CUITe_ControlBase
    {
        private SilverlightButton _SlButton;

        public CUITe_SlButton(string sSearchParameters) : base(sSearchParameters) { }

        public void Wrap(SilverlightButton control)
        {
            base.Wrap(control);
            this._SlButton = control;
        }

        public SilverlightButton UnWrap()
        {
            return this._SlButton;
        }
    }
}
