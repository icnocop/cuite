using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightTabItem.
    /// </summary>
    public class CUITe_SlTabItem : CUITe_SlControl<SilverlightTabItem>
    {
        public CUITe_SlTabItem() : base() { }
        public CUITe_SlTabItem(string searchParameters) : base(searchParameters) { }
    }
}
