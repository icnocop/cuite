using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinColumnHeader
    /// </summary>
    public class CUITe_WinColumnHeader : CUITe_WinControl<WinColumnHeader>
    {
        public CUITe_WinColumnHeader() : base() { }
        public CUITe_WinColumnHeader(string searchParameters) : base(searchParameters) { }
    }
}