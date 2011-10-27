using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlSpan : CUITe_HtmlControl<HtmlSpan>
    {
        public CUITe_HtmlSpan() : base() { }
        public CUITe_HtmlSpan(string sSearchParameters) : base(sSearchParameters) { }
    }
}
