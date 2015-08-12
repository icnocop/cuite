#if SILVERLIGHT_SUPPORT
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUIT = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    public class SilverlightControl<T> : CUITe_ControlBase<T> where T : CUIT.SilverlightControl
    {
        public SilverlightControl() : base() { }
        public SilverlightControl(string searchParameters) : base(searchParameters) { }

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
                    ret = WrapUtil((CUIT.SilverlightControl)this._control.GetParent());
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
                    ret = WrapUtil((CUIT.SilverlightControl)this._control.GetParent().GetChildren()[GetMyIndexAmongSiblings() - 1]);
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
                    ret = WrapUtil((CUIT.SilverlightControl)this._control.GetParent().GetChildren()[GetMyIndexAmongSiblings() + 1]);
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
                    ret = WrapUtil((CUIT.SilverlightControl)this._control.GetChildren()[0]);
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
                uicol.Add(WrapUtil((CUIT.SilverlightControl)uitestcontrol));
            }
            return uicol;
        }

        private ICUITe_ControlBase WrapUtil(CUIT.SilverlightControl control)
        {
            ICUITe_ControlBase _con = null;
            if (control.GetType() == typeof(CUIT.SilverlightButton))
            {
                _con = new SilverlightButton();
            }
            else if (control.GetType() == typeof(CUIT.SilverlightCalendar))
            {
                _con = new SilverlightCalendar();
            }
            else if (control.GetType() == typeof(CUIT.SilverlightCell))
            {
                _con = new SilverlightCell();
            }
            else if (control.GetType() == typeof(CUIT.SilverlightCheckBox))
            {
                _con = new SilverlightCheckBox();
            }
            else if (control.GetType() == typeof(CUIT.SilverlightComboBox))
            {
                _con = new SilverlightComboBox();
            }
            else if (control.GetType() == typeof(CUIT.SilverlightDataPager))
            {
                _con = new SilverlightDataPager();
            }
            else if (control.GetType() == typeof(CUIT.SilverlightDatePicker))
            {
                _con = new SilverlightDatePicker();
            }
            else if (control.GetType() == typeof(CUIT.SilverlightEdit))
            {
                _con = new SilverlightEdit();
            }
            else if (control.GetType() == typeof(CUIT.SilverlightHyperlink))
            {
                _con = new SilverlightHyperlink();
            }
            else if (control.GetType() == typeof(CUIT.SilverlightImage))
            {
                _con = new SilverlightImage();
            }
            else if (control.GetType() == typeof(CUIT.SilverlightLabel))
            {
                _con = new SilverlightLabel();
            }
            else if (control.GetType() == typeof(CUIT.SilverlightList))
            {
                _con = new SilverlightList();
            }
            else if (control.GetType() == typeof(CUIT.SilverlightRadioButton))
            {
                _con = new SilverlightRadioButton();
            }
            else if (control.GetType() == typeof(CUIT.SilverlightSlider))
            {
                _con = new SilverlightSlider();
            }
            else if (control.GetType() == typeof(CUIT.SilverlightTab))
            {
                _con = new SilverlightTab();
            }
            else if (control.GetType() == typeof(CUIT.SilverlightTabItem))
            {
                _con = new SilverlightTabItem();
            }
            else if (control.GetType() == typeof(CUIT.SilverlightTable))
            {
                _con = new SilverlightTable();
            }
            else if (control.GetType() == typeof(CUIT.SilverlightText))
            {
                _con = new SilverlightText();
            }
            else if (control.GetType() == typeof(CUIT.SilverlightTree))
            {
                _con = new SilverlightTree();
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
#endif