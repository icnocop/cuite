using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    public class CUITe_SlImage : CUITe_SlControl<SilverlightImage>
    {
        public CUITe_SlImage() : base() { }
        public CUITe_SlImage(string sSearchParameters) : base(sSearchParameters) { }
    }
}
