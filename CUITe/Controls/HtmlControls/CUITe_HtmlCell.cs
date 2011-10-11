using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlCell : CUITe_ControlBase<HtmlCell>
    {
        public CUITe_HtmlCell() : base() { }
        public CUITe_HtmlCell(string sSearchProperties) : base(sSearchProperties) { }
    }
}
