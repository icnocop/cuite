using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    public class CUITe_SlText : CUITe_SlControl<SilverlightText>
    {
        public CUITe_SlText() : base() { }
        public CUITe_SlText(string sSearchParameters) : base(sSearchParameters) { }
    }
}
