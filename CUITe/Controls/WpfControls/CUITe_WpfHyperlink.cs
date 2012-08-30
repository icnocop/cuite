using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfHyperlink
    /// </summary>
    public class CUITe_WpfHyperlink : CUITe_WpfControl<WpfHyperlink>
    {
        public CUITe_WpfHyperlink() : base() { }
        public CUITe_WpfHyperlink(string searchParameters) : base(searchParameters) { }

        public string Alt
        {
            get { return this.UnWrap().Alt; }
        }
    }
}