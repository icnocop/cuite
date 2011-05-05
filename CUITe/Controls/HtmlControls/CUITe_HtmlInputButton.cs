using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlInputButton : CUITe_ControlBase
    {
        private HtmlInputButton _htmlInputButton;

        public CUITe_HtmlInputButton(string sSearchParameters) : base(sSearchParameters) { }

        public void Wrap(HtmlInputButton control)
        {
            base.Wrap(control);
            this._htmlInputButton = control;
        }

        public HtmlInputButton UnWrap()
        {
            return this._htmlInputButton;
        }

        public string InnerText
        {
            get
            {
                return this._htmlInputButton.InnerText;
            }
        }

        public string DisplayText
        {
            get
            {
                return this._htmlInputButton.DisplayText;
            }
        }
    }
}
