using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfButton
    /// </summary>
    public class CUITe_WpfButton : CUITe_WpfControl<WpfButton>
    {
        public CUITe_WpfButton() : base() { }
        public CUITe_WpfButton(string sSearchParameters) : base(sSearchParameters) { }

        public string DisplayText { get { return this.UnWrap().DisplayText; } }

    }
}