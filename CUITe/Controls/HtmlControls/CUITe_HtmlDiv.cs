using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlDiv : CUITe_ControlBase<HtmlDiv>
    {
        public CUITe_HtmlDiv() : base() { }
        public CUITe_HtmlDiv(string sSearchParameters) : base(sSearchParameters) { }

        public string InnerText
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.InnerText;
            }
        }
    }
}
