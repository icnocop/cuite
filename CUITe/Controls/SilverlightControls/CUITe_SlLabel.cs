using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightLabel.
    /// </summary>
    public class CUITe_SlLabel : CUITe_SlControl<SilverlightLabel>
    {
        public CUITe_SlLabel() : base() { }
        public CUITe_SlLabel(string sSearchParameters) : base(sSearchParameters) { }
    }
}
