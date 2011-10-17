using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightTab.
    /// </summary>
    public class CUITe_SlTab : CUITe_SlControl<SilverlightTab>
    {
        public CUITe_SlTab() : base() { }
        public CUITe_SlTab(string sSearchParameters) : base(sSearchParameters) { }
    }
}
