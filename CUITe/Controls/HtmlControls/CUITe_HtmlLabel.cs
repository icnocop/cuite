using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlLabel : CUITe_HtmlControl<HtmlLabel>
    {
        public CUITe_HtmlLabel() : base() { }
        public CUITe_HtmlLabel(string sSearchParameters) : base(sSearchParameters) { }
    }
}
