using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightTree.
    /// </summary>
    public class CUITe_SlTree : CUITe_SlControl<SilverlightTree>
    {
        public CUITe_SlTree() : base() { }
        public CUITe_SlTree(string sSearchParameters) : base(sSearchParameters) { }
    }
}
