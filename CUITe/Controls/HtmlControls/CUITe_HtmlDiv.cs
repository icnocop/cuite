using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlDiv : CUITe_HtmlControl<HtmlDiv>
    {
        public CUITe_HtmlDiv() : base() { }
        public CUITe_HtmlDiv(string searchParameters) : base(searchParameters) { }
    }
}
