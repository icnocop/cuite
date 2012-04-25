using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfText
    /// </summary>
    public class CUITe_WpfText : CUITe_WpfControl<WpfText>
    {
        public CUITe_WpfText() : base() { }
        public CUITe_WpfText(string sSearchParameters) : base(sSearchParameters) { }

        public string DisplayText
        {
            get { return this.UnWrap().DisplayText; }
        }
    }
}