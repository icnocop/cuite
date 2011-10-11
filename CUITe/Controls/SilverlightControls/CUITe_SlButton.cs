using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    public class CUITe_SlButton : CUITe_ControlBase<SilverlightButton>
    {
        public CUITe_SlButton() : base() { }
        public CUITe_SlButton(string sSearchParameters) : base(sSearchParameters) { }
    }
}
