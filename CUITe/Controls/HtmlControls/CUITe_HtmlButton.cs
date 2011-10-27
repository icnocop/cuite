using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlButton : CUITe_HtmlControl<HtmlButton>
    {
        public CUITe_HtmlButton() : base() { }
        public CUITe_HtmlButton(string sSearchParameters) : base(sSearchParameters) { }
    }
}
