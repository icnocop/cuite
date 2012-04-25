using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinSeparator
    /// </summary>
    public class CUITe_WinSeparator : CUITe_WinControl<WinSeparator>
    {
        public CUITe_WinSeparator() : base() { }
        public CUITe_WinSeparator(string sSearchParameters) : base(sSearchParameters) { }
    }
}