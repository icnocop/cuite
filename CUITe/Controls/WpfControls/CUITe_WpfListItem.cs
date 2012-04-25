using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfListItem
    /// </summary>
    public class CUITe_WpfListItem : CUITe_WpfControl<WpfListItem>
    {
        public CUITe_WpfListItem() : base() { }
        public CUITe_WpfListItem(string sSearchParameters) : base(sSearchParameters) { }

        public string DisplayText
        {
            get { return this.UnWrap().DisplayText; }
        }

        public bool Selected
        {
            get { return this.UnWrap().Selected; }
        }
    }
}