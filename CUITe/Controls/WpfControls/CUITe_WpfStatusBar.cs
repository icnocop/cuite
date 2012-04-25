using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfStatusBar
    /// </summary>
    public class CUITe_WpfStatusBar : CUITe_WpfControl<WpfStatusBar>
    {
        public CUITe_WpfStatusBar() : base() { }
        public CUITe_WpfStatusBar(string sSearchParameters) : base(sSearchParameters) { }

        public UITestControlCollection Panels
        {
            get { return this.UnWrap().Panels; }
        }
    }
}