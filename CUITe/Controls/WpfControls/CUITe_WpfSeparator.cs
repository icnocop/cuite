using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfSeparator
    /// </summary>
    public class CUITe_WpfSeparator : CUITe_WpfControl<WpfSeparator>
    {
        public CUITe_WpfSeparator() : base() { }
        public CUITe_WpfSeparator(string sSearchParameters) : base(sSearchParameters) { }
    }
}