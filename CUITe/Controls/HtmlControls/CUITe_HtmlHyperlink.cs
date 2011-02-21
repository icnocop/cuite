using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlHyperlink : CUITe_ControlBase
    {
        private HtmlHyperlink _htmlHyperlink;

        public CUITe_HtmlHyperlink(string sSearchParameters) : base(sSearchParameters) { }

        public void Wrap(HtmlHyperlink control)
        {
            base.Wrap(control);
            this._htmlHyperlink = control;
        }

        public HtmlHyperlink UnWrap()
        {
            return this._htmlHyperlink;
        }
    }
}
