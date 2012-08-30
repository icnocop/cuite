using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinSpinner
    /// </summary>
    public class CUITe_WinSpinner : CUITe_WinControl<WinSpinner>
    {
        public CUITe_WinSpinner() : base() { }
        public CUITe_WinSpinner(string searchParameters) : base(searchParameters) { }

        public int MaximumValue
        {
            get { return this.UnWrap().MaximumValue; }
        }

        public int MinimumValue
        {
            get { return this.UnWrap().MinimumValue; }
        }
    }
}