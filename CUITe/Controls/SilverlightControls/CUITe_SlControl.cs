using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    public class CUITe_SlControl<T> : CUITe_ControlBase<T> where T : SilverlightControl
    {
        public CUITe_SlControl() : base() { }
        public CUITe_SlControl(string searchParameters) : base(searchParameters) { }

        /// <summary>
        /// Gets the control's label text.
        /// </summary>
        public string LabeledBy
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.LabeledBy;
            }
        }

        /// <summary>
        /// Gets the parent of the current CUITe control.
        /// </summary>
        public override ICUITe_ControlBase Parent
        {
            get
            {
                this._control.WaitForControlReady();
                ICUITe_ControlBase ret = null;
                try
                {
                    ret = WrapUtil((SilverlightControl)this._control.GetParent());
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    throw new CUITe_InvalidTraversal(string.Format("({0}).Parent", this._control.GetType().Name));
                }
                return ret;
            }
        }

        /// <summary>
        /// Gets the previous sibling of the current CUITe control.
        /// </summary>
        public override ICUITe_ControlBase PreviousSibling
        {
            get
            {
                this._control.WaitForControlReady();
                ICUITe_ControlBase ret = null;
                try
                {
                    ret = WrapUtil((SilverlightControl)this._control.GetParent().GetChildren()[GetMyIndexAmongSiblings() - 1]);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    throw new CUITe_InvalidTraversal(string.Format("({0}).PreviousSibling", this._control.GetType().Name));
                }
                return ret;
            }
        }

        /// <summary>
        /// Gets the next sibling of the current CUITe control.
        /// </summary>
        public override ICUITe_ControlBase NextSibling
        {
            get
            {
                this._control.WaitForControlReady();
                ICUITe_ControlBase ret = null;
                try
                {
                    ret = WrapUtil((SilverlightControl)this._control.GetParent().GetChildren()[GetMyIndexAmongSiblings() + 1]);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    throw new CUITe_InvalidTraversal(string.Format("({0}).NextSibling", this._control.GetType().Name));
                }
                return ret;
            }
        }

        /// <summary>
        /// Gets the first child of the current CUITe control.
        /// </summary>
        public override ICUITe_ControlBase FirstChild
        {
            get
            {
                this._control.WaitForControlReady();
                ICUITe_ControlBase ret = null;
                try
                {
                    ret = WrapUtil((SilverlightControl)this._control.GetChildren()[0]);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    throw new CUITe_InvalidTraversal(string.Format("({0}).FirstChild", this._control.GetType().Name));
                }
                return ret;
            }
        }

        /// <summary>
        /// Returns a list of all first level children of the current CUITe control.
        /// </summary>
        /// <returns>list of all first level children</returns>
        public override List<ICUITe_ControlBase> GetChildren()
        {
            this._control.WaitForControlReady();
            var uicol = new List<ICUITe_ControlBase>();
            foreach (UITestControl uitestcontrol in this._control.GetChildren())
            {
                uicol.Add(WrapUtil((SilverlightControl)uitestcontrol));
            }
            return uicol;
        }

        private ICUITe_ControlBase WrapUtil(SilverlightControl control)
        {
            ICUITe_ControlBase _con = null;
            if (control.GetType() == typeof(SilverlightButton))
            {
                _con = new CUITe_SlButton();
            }
            else if (control.GetType() == typeof(SilverlightCalendar))
            {
                _con = new CUITe_SlCalendar();
            }
            else if (control.GetType() == typeof(SilverlightCell))
            {
                _con = new CUITe_SlCell();
            }
            else if (control.GetType() == typeof(SilverlightCheckBox))
            {
                _con = new CUITe_SlCheckBox();
            }
            else if (control.GetType() == typeof(SilverlightComboBox))
            {
                _con = new CUITe_SlComboBox();
            }
            else if (control.GetType() == typeof(SilverlightDataPager))
            {
                _con = new CUITe_SlDataPager();
            }
            else if (control.GetType() == typeof(SilverlightDatePicker))
            {
                _con = new CUITe_SlDatePicker();
            }
            else if (control.GetType() == typeof(SilverlightEdit))
            {
                _con = new CUITe_SlEdit();
            }
            else if (control.GetType() == typeof(SilverlightHyperlink))
            {
                _con = new CUITe_SlHyperlink();
            }
            else if (control.GetType() == typeof(SilverlightImage))
            {
                _con = new CUITe_SlImage();
            }
            else if (control.GetType() == typeof(SilverlightLabel))
            {
                _con = new CUITe_SlLabel();
            }
            else if (control.GetType() == typeof(SilverlightList))
            {
                _con = new CUITe_SlList();
            }
            else if (control.GetType() == typeof(SilverlightRadioButton))
            {
                _con = new CUITe_SlRadioButton();
            }
            else if (control.GetType() == typeof(SilverlightSlider))
            {
                _con = new CUITe_SlSlider();
            }
            else if (control.GetType() == typeof(SilverlightTab))
            {
                _con = new CUITe_SlTab();
            }
            else if (control.GetType() == typeof(SilverlightTabItem))
            {
                _con = new CUITe_SlTabItem();
            }
            else if (control.GetType() == typeof(SilverlightTable))
            {
                _con = new CUITe_SlTable();
            }
            else if (control.GetType() == typeof(SilverlightText))
            {
                _con = new CUITe_SlText();
            }
            else if (control.GetType() == typeof(SilverlightTree))
            {
                _con = new CUITe_SlTree();
            }
            else
            {
                throw new Exception(string.Format("WrapUtil: '{0}' is not supported.", control.GetType().ToString()));
            }

            ((ICUITe_ControlBase)_con).WrapReady(control);
            return _con;
        }

        private int GetMyIndexAmongSiblings()
        {
            int i = -1;
            foreach (UITestControl uitestcontrol in this._control.GetParent().GetChildren())
            {
                i++;
                if (uitestcontrol == this._control)
                {
                    break;
                }
            }
            return i;
        }
    }
}
