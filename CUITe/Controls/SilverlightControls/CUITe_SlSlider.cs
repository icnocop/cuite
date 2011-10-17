using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightSlider.
    /// </summary>
    public class CUITe_SlSlider : CUITe_SlControl<SilverlightSlider>
    {
        public CUITe_SlSlider() : base() { }
        public CUITe_SlSlider(string sSearchParameters) : base(sSearchParameters) { }
    }
}
