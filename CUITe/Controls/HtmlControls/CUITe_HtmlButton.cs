using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlButton : CUITe_ControlBase
    {
        private HtmlButton _htmlButton;

        public CUITe_HtmlButton(string sSearchParameters) : base(sSearchParameters) { }

        public void Wrap(HtmlButton control)
        {
            base.Wrap(control);
            this._htmlButton = control;
        }

        public HtmlButton UnWrap()
        {
            return this._htmlButton;
        }
    }
}
