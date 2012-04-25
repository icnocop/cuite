using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinStatusBar
    /// </summary>
    public class CUITe_WinStatusBar : CUITe_WinControl<WinStatusBar>
    {
        public CUITe_WinStatusBar() : base() { }
        public CUITe_WinStatusBar(string sSearchParameters) : base(sSearchParameters) { }

        public UITestControlCollection Panels
        {
            get { return this.UnWrap().Panels; }
        }
    }
}