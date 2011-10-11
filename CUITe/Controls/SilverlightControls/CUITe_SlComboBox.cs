using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    public class CUITe_SlComboBox : CUITe_ControlBase<SilverlightComboBox>
    {
        public CUITe_SlComboBox() : base() { }
        public CUITe_SlComboBox(string sSearchParameters) : base(sSearchParameters) { }

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
