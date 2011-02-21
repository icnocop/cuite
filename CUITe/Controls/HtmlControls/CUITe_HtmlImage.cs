using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlImage : CUITe_ControlBase
    {
        private HtmlImage _htmlImage;

        public CUITe_HtmlImage(string sSearchParameters) : base(sSearchParameters) { }

        public void Wrap(HtmlImage control)
        {
            base.Wrap(control);
            this._htmlImage = control;
        }

        public HtmlImage UnWrap()
        {
            return this._htmlImage;
        }
    }
}
