using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfGroup
    /// </summary>
    public class CUITe_WpfGroup : CUITe_WpfControl<WpfGroup>
    {
        public CUITe_WpfGroup() : base() { }
        public CUITe_WpfGroup(string searchParameters) : base(searchParameters) { }

        public string Header
        {
            get { return this.UnWrap().Header; }
        }
    }
}