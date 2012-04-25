using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfPane
    /// </summary>
    public class CUITe_WpfPane : CUITe_WpfControl<WpfPane>
    {
        public CUITe_WpfPane() : base() { }
        public CUITe_WpfPane(string sSearchParameters) : base(sSearchParameters) { }
    }
}