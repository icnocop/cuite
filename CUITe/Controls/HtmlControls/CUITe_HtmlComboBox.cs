using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlComboBox : CUITe_ControlBase
    {
        private HtmlComboBox _htmlComboBox;

        public CUITe_HtmlComboBox(string sSearchParameters) : base(sSearchParameters) { }

        public void Wrap(HtmlComboBox control)
        {
            base.Wrap(control);
            this._htmlComboBox = control;
        }

        public HtmlComboBox UnWrap()
        {
            return this._htmlComboBox;
        }

        public void SelectItem(string sItem)
        {
            this._htmlComboBox.WaitForControlReady();
            this._htmlComboBox.SelectedItem = sItem;
        }

        public string SelectedItem
        {
            get 
            {
                this._htmlComboBox.WaitForControlReady();
                return this._htmlComboBox.SelectedItem; 
            }
        }
    }
}
