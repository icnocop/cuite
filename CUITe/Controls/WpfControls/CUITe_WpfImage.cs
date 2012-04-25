using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfImage
    /// </summary>
    public class CUITe_WpfImage : CUITe_WpfControl<WpfImage>
    {
        public CUITe_WpfImage() : base() { }
        public CUITe_WpfImage(string sSearchParameters) : base(sSearchParameters) { }

        public string Alt
        {
            get { return this.UnWrap().Alt; }
        }
    }
}