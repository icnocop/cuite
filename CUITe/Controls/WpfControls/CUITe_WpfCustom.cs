using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfCustom
    /// </summary>
    public class CUITe_WpfCustom : CUITe_WpfControl<WpfCustom>
    {
        public CUITe_WpfCustom() : base() { }
        public CUITe_WpfCustom(string sSearchParameters) : base(sSearchParameters) { }
    }
}