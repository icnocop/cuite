using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlComboBox : CUITe_ControlBase<HtmlComboBox>
    {
        public CUITe_HtmlComboBox() : base() { }
        public CUITe_HtmlComboBox(string sSearchParameters) : base(sSearchParameters) { }

        public void SelectItem(string sItem)
        {
            this._control.WaitForControlReady();
            this._control.SelectedItem = sItem;
        }

        public string SelectedItem
        {
            get 
            {
                this._control.WaitForControlReady();
                return this._control.SelectedItem; 
            }
        }
    }
}
