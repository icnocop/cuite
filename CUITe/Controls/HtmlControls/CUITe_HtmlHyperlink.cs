using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlHyperlink : CUITe_HtmlControl<HtmlHyperlink>
    {
        public CUITe_HtmlHyperlink() : base() { }
        public CUITe_HtmlHyperlink(string searchParameters) : base(searchParameters) { }
    }
}
