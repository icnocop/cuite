using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinGroup
    /// </summary>
    public class CUITe_WinGroup : CUITe_WinControl<WinGroup>
    {
        public CUITe_WinGroup() : base() { }
        public CUITe_WinGroup(string searchParameters) : base(searchParameters) { }
    }
}