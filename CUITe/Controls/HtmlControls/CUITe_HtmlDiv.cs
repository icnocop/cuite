using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlDiv : CUITe_ControlBase
    {
        private HtmlDiv _htmlDiv;

        public CUITe_HtmlDiv(string sSearchParameters) : base(sSearchParameters) { }

        public void Wrap(HtmlDiv control)
        {
            base.Wrap(control);
            this._htmlDiv = control;
        }

        public HtmlDiv UnWrap()
        {
            return this._htmlDiv;
        }

        public string InnerText
        {
            get
            {
                this._htmlDiv.WaitForControlReady();
                return this._htmlDiv.InnerText;
            }
        }
    }
}
