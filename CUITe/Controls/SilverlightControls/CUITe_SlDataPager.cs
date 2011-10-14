using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    public class CUITe_SlDataPager : CUITe_SlControl<SilverlightDataPager>
    {
        public CUITe_SlDataPager() : base() { }
        public CUITe_SlDataPager(string sSearchParameters) : base(sSearchParameters) { }
    }
}
