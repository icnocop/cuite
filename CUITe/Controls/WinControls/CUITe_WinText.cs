using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;


namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinText
    /// </summary>
    public class CUITe_WinText : CUITe_WinControl<WinText>
    {
        public CUITe_WinText() : base() { }
        public CUITe_WinText(string sSearchParameters) : base(sSearchParameters) { }

        public string DisplayText
        {
            get { return this.UnWrap().DisplayText; }
        }
    }
}
