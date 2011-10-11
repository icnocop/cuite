using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlImage : CUITe_ControlBase<HtmlImage>
    {
        public CUITe_HtmlImage() : base() { }
        public CUITe_HtmlImage(string sSearchParameters) : base(sSearchParameters) { }
    }
}
