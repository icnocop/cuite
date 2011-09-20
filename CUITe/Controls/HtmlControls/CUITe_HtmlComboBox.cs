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

        /// <summary>
        /// Helps you wrap a HtmlComboBox control with a CUITe_HtmlComboBox to leverage CUITe's convenient methods.
        /// </summary>
        /// <param name="control"></param>
        /// <example>
        /// <code>
        /// CUITe_HtmlComboBox cmbEdit = new CUITe_HtmlComboBox();
        /// cmbEdit.WrapReady(edit);
        /// cmbEdit.SelectItem("blah blah blah");
        /// </code>
        /// Here 'edit' is a HtmlComboBox object.
        /// </example>
        public void WrapReady(HtmlComboBox control)
        {
            base.WrapReady(control);
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
