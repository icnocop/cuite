using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    public class CUITe_SlControl : CUITe_ControlBase<SilverlightControl>
    {
        public CUITe_SlControl() : base() { }
        public CUITe_SlControl(string sSearchParameters) : base(sSearchParameters) { }
    }
}
