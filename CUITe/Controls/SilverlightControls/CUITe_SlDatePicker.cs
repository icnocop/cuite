using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    public class CUITe_SlDatePicker : CUITe_SlControl<SilverlightDatePicker>
    {
        public CUITe_SlDatePicker() : base() { }
        public CUITe_SlDatePicker(string sSearchParameters) : base(sSearchParameters) { }
    }
}
