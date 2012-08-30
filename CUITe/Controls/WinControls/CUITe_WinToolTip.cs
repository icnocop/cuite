using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinToolTip
    /// </summary>
    public class CUITe_WinToolTip : CUITe_WinControl<WinToolTip>
    {
        public CUITe_WinToolTip() : base() { }
        public CUITe_WinToolTip(string searchParameters) : base(searchParameters) { }
    }
}