using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlSpan : CUITe_ControlBase
    {
        private HtmlSpan _htmlSpan;

        public CUITe_HtmlSpan(string sSearchParameters) : base(sSearchParameters) { }

        public void Wrap(HtmlSpan control)
        {
            base.Wrap(control);
            this._htmlSpan = control;
        }

        public HtmlSpan UnWrap()
        {
            return this._htmlSpan;
        }

        public string InnerText
        {
            get
            {
                this._htmlSpan.WaitForControlReady();
                return this._htmlSpan.InnerText;
            }
        }
    }
}
