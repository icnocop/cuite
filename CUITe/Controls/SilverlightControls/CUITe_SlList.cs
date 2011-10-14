using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    public class CUITe_SlList : CUITe_SlControl<SilverlightList>
    {
        public CUITe_SlList() : base() { }
        public CUITe_SlList(string sSearchParameters) : base(sSearchParameters) { }

        public UITestControlCollection Items
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.Items;
            }
        }

        public int[] SelectedIndices
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.SelectedIndices;
            }
            set
            {
                this._control.WaitForControlReady();
                this._control.SelectedIndices = value;
            }
        }

        public string[] SelectedItems
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.SelectedItems;
            }
            set
            {
                this._control.WaitForControlReady();
                this._control.SelectedItems = value;
            }
        }

        public string SelectedItemsAsString
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.SelectedItemsAsString;
            }
            set
            {
                this._control.WaitForControlReady();
                this._control.SelectedItemsAsString = value;
            }
        }

        public System.Windows.Forms.SelectionMode SelectionMode
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.SelectionMode;
            }
        }
    }
}
