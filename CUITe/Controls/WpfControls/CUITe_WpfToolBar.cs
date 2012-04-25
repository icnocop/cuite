using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfToolBar
    /// </summary>
    public class CUITe_WpfToolBar : CUITe_WpfControl<WpfToolBar>
    {
        public CUITe_WpfToolBar() : base() { }
        public CUITe_WpfToolBar(string sSearchParameters) : base(sSearchParameters) { }

        public string Header
        {
            get { return this.UnWrap().Header; }
        }

        public UITestControlCollection Items
        {
            get { return this.UnWrap().Items; }
        }
    }
}