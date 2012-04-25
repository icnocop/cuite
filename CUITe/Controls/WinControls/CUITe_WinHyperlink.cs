using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinHyperLink
    /// </summary>
    public class CUITe_WinHyperlink : CUITe_WinControl<WinHyperlink>
    {
        public CUITe_WinHyperlink() : base() { }
        public CUITe_WinHyperlink(string sSearchParameters) : base(sSearchParameters) { }

        public string DisplayText
        {
            get { return this.UnWrap().DisplayText; }
        }
    }
}