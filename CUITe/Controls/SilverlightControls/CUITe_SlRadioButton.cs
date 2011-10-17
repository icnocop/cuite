using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightRadioButton.
    /// </summary>
    public class CUITe_SlRadioButton : CUITe_SlControl<SilverlightRadioButton>
    {
        public CUITe_SlRadioButton() : base() { }
        public CUITe_SlRadioButton(string sSearchParameters) : base(sSearchParameters) { }
    }
}
