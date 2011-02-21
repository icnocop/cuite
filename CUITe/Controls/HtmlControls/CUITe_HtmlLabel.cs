using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlLabel : CUITe_ControlBase
    {
        private HtmlLabel _htmlLabel;

        public CUITe_HtmlLabel(string sSearchParameters) : base(sSearchParameters) { }

        public void Wrap(HtmlLabel control)
        {
            base.Wrap(control);
            this._htmlLabel = control;
        }

        public HtmlLabel UnWrap()
        {
            return this._htmlLabel;
        }

        public string InnerText
        {
            get
            {
                this._htmlLabel.WaitForControlReady();
                return this._htmlLabel.InnerText;
            }
        }
    }
}
