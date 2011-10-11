using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlList : CUITe_ControlBase<HtmlList>
    {
        public CUITe_HtmlList() : base() { }
        public CUITe_HtmlList(string sSearchParameters) : base(sSearchParameters) { }

        public void Select(string sItem)
        {
            this._control.WaitForControlReady();
            this._control.SelectedItemsAsString = sItem;
        }
    }
}
