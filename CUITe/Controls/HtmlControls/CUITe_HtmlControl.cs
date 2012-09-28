using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    /// <summary>
    /// Base class for all CUITe_Html controls, inherits from CUITe_ControlBase
    /// </summary>
    /// <typeparam name="T">The Coded UI Test Html control type</typeparam>
    public class CUITe_HtmlControl<T> : CUITe_ControlBase<T> where T : HtmlControl
    {
        public CUITe_HtmlControl()
            : base()
        {
        }

        public CUITe_HtmlControl(string searchParameters)
            : base(searchParameters)
        {
        }

        public CUITe_HtmlControl(HtmlControl control)
            : base()
        {
            this._control = (T)control;
        }

        /// <summary>
        /// Gets the text content of this control.
        /// </summary>
        public string InnerText
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.InnerText;
            }
        }

        /// <summary>
        /// Gets the value of the Help Text attribute of this control.
        /// </summary>
        public string HelpText
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.HelpText;
            }
        }

        /// <summary>
        /// Gets the value of the Title attribute of this control.
        /// </summary>
        public string Title
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.Title;
            }
        }

        /// <summary>
        /// Gets the value of the Value attribute of this control.
        /// </summary>
        public string ValueAttribute
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.ValueAttribute;
            }
        }

        /// <summary>
        /// Gets the value of the AccessKey attribute of this control.
        /// </summary>
        public string AccessKey
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.AccessKey;
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
                    ret = WrapUtil((HtmlControl)this._control.GetParent());
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
                    ret = WrapUtil((HtmlControl)this._control.GetParent().GetChildren()[GetMyIndexAmongSiblings() - 1]);
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
                    ret = WrapUtil((HtmlControl)this._control.GetParent().GetChildren()[GetMyIndexAmongSiblings() + 1]);
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
                    ret = WrapUtil((HtmlControl)this._control.GetChildren()[0]);
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
                uicol.Add(WrapUtil((HtmlControl)uitestcontrol));
            }
            return uicol;
        }

        protected T1[] GetPropertyOfChildren<T1>(string propertyName)
        {
            this._control.WaitForControlReady();
            var collection = this._control.GetChildren();
            if (collection != null)
            {
                T1[] tmpArray = new T1[collection.Count];
                for (int i = 0; i < tmpArray.Length; i++)
                {
                    tmpArray[i] = (T1)collection[i].GetProperty(propertyName);
                }
                return tmpArray;
            }
            return null;
        }

        private ICUITe_ControlBase WrapUtil(HtmlControl control)
        {
            ICUITe_ControlBase _con = null;
            if (control.GetType() == typeof(HtmlButton))
            {
                _con = new CUITe_HtmlButton();
            }
            else if (control.GetType() == typeof(HtmlCheckBox))
            {
                _con = new CUITe_HtmlCheckBox();
            }
            else if (control.GetType() == typeof(HtmlComboBox))
            {
                _con = new CUITe_HtmlComboBox();
            }
            else if (control.GetType() == typeof(HtmlDiv))
            {
                _con = new CUITe_HtmlDiv();
            }
            else if (control.GetType() == typeof(HtmlEdit) && (string.Compare(control.Type, "password", true) == 0))
            {
                _con = new CUITe_HtmlPassword();
            }
            else if (control.GetType() == typeof(HtmlEdit))
            {
                _con = new CUITe_HtmlEdit();
            }
            else if (control.GetType() == typeof(HtmlFileInput))
            {
                _con = new CUITe_HtmlFileInput();
            }
            else if (control.GetType() == typeof(HtmlHyperlink))
            {
                _con = new CUITe_HtmlHyperlink();
            }
            else if (control.GetType() == typeof(HtmlImage))
            {
                _con = new CUITe_HtmlImage();
            }
            else if (control.GetType() == typeof(HtmlInputButton))
            {
                _con = new CUITe_HtmlInputButton();
            }
            else if (control.GetType() == typeof(HtmlLabel))
            {
                _con = new CUITe_HtmlLabel();
            }
            else if (control.GetType() == typeof(HtmlList))
            {
                _con = new CUITe_HtmlList();
            }
            else if (control.GetType() == typeof(HtmlRadioButton))
            {
                _con = new CUITe_HtmlRadioButton();
            }
            else if (control.GetType() == typeof(HtmlSpan))
            {
                _con = new CUITe_HtmlSpan();
            }
            else if (control.GetType() == typeof(HtmlTable))
            {
                _con = new CUITe_HtmlTable();
            }
            else if (control.GetType() == typeof(HtmlCell))
            {
                _con = new CUITe_HtmlCell();
            }
            else if (control.GetType() == typeof(HtmlTextArea))
            {
                _con = new CUITe_HtmlTextArea();
            }
            else if (control.GetType() == typeof(HtmlCustom))
            {
                if (control.TagName == "p")
                {
                    _con = new CUITe_HtmlParagraph();
                }
                else if (control.TagName == "h1")
                {
                    _con = new CUITe_HtmlHeading1();
                }
                else if (control.TagName == "h2")
                {
                    _con = new CUITe_HtmlHeading2();
                }
                else if (control.TagName == "h3")
                {
                    _con = new CUITe_HtmlHeading3();
                }
                else if (control.TagName == "h4")
                {
                    _con = new CUITe_HtmlHeading4();
                }
                else if (control.TagName == "h5")
                {
                    _con = new CUITe_HtmlHeading5();
                }
                else if (control.TagName == "h6")
                {
                    _con = new CUITe_HtmlHeading6();
                }
                else if (control.TagName == "ul")
                {
                    _con = new CUITe_HtmlUnorderedList();
                }
                else if (control.TagName == "ol")
                {
                    _con = new CUITe_HtmlOrderedList();
                }
                else if (control.TagName == "LI")
                {
                    _con = new CUITe_HtmlListItem();
                }
                else
                {
                    _con = new CUITe_HtmlCustom(control.TagName);
                }
            }
            else
            {
                throw new Exception(string.Format("WrapUtil: '{0}' not supported", control.GetType().Name));
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
