using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlCell : CUITe_ControlBase
    {
        private HtmlCell _htmlCell;

        public CUITe_HtmlCell(string sSearchParameters) : base(sSearchParameters) { }

        public void Wrap(HtmlCell control)
        {
            base.Wrap(control);
            this._htmlCell = control;
        }

        public HtmlCell UnWrap()
        {
            return this._htmlCell;
        }
    }
}
