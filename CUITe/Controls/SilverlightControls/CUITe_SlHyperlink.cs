using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    public class CUITe_SlHyperlink : CUITe_ControlBase
    {
        private SilverlightHyperlink _SlHyperlink;

        public CUITe_SlHyperlink(string sSearchParameters) : base(sSearchParameters) { }

        public void Wrap(SilverlightHyperlink control)
        {
            base.Wrap(control);
            this._SlHyperlink = control;
        }

        public SilverlightHyperlink UnWrap()
        {
            return this._SlHyperlink;
        }
    }
}
