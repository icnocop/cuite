using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinSplitButton
    /// </summary>
    public class CUITe_WinSplitButton : CUITe_WinControl<WinSplitButton>
    {
        public CUITe_WinSplitButton() : base() { }
        public CUITe_WinSplitButton(string searchParameters) : base(searchParameters) { }

        public string DisplayText
        {
            get { return this.UnWrap().DisplayText; }
        }

        public string Shortcut
        {
            get { return this.UnWrap().Shortcut; }
        }
    }
}