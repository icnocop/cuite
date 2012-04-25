using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfTabPage
    /// </summary>
    public class CUITe_WpfTabPage : CUITe_WpfControl<WpfTabPage>
    {
        public CUITe_WpfTabPage() : base() { }
        public CUITe_WpfTabPage(string sSearchParameters) : base(sSearchParameters) { }

        public string Header
        {
            get { return this.UnWrap().Header; }
        }
    }
}