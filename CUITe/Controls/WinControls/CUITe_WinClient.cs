using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinClient
    /// </summary>
    public class CUITe_WinClient : CUITe_WinControl<WinClient>
    {
        public CUITe_WinClient() : base() { }
        public CUITe_WinClient(string searchParameters) : base(searchParameters) { }
    }
}