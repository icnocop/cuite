using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    public class CUITe_SlDataPager: CUITe_ControlBase
    {
        private SilverlightDataPager _SlDataPager;

        public CUITe_SlDataPager(string sSearchParameters) : base(sSearchParameters) { }

        public void Wrap(SilverlightDataPager control)
        {
            base.Wrap(control);
            this._SlDataPager = control;
        }

        public SilverlightDataPager UnWrap()
        {
            return this._SlDataPager;
        }
    }
}
