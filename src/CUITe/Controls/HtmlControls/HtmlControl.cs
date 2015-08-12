using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlControl : CUITe_ControlBase<CUITControls.HtmlControl>
    {
        public HtmlControl(string tagName)
            : base()
        {
            Initialize(tagName);
        }

        public HtmlControl(string tagName, string searchParameters)
            : base(searchParameters)
        {
            Initialize(tagName);
        }

        private void Initialize(string tagName)
        {
            this.SearchProperties.Add(CUITControls.HtmlControl.PropertyNames.TagName, tagName, PropertyExpressionOperator.EqualTo);
        }
    }

    /// <summary>
    /// Base class for all CUITe_Html controls, inherits from CUITe_ControlBase
    /// </summary>
    /// <typeparam name="T">The Coded UI Test Html control type</typeparam>
    public class HtmlControl<T> : CUITe_ControlBase<T>, IHtmlControl
        where T : CUITControls.HtmlControl
    {
        public HtmlControl()
            : base()
        {
        }

        public HtmlControl(string searchParameters)
            : base(searchParameters)
        {
        }

        public HtmlControl(UITestControl control)
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
                    ret = WrapUtil((CUITControls.HtmlControl)this._control.GetParent());
                }
                catch (ArgumentOutOfRangeException)
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
                    ret = WrapUtil((CUITControls.HtmlControl)this._control.GetParent().GetChildren()[GetMyIndexAmongSiblings() - 1]);
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
                    UITestControl parent = this._control.GetParent();

                    UITestControlCollection children = parent.GetChildren();

                    int thisIndex = GetMyIndexAmongSiblings();

                    UITestControl child = children[thisIndex + 1];

                    ret = WrapUtil((CUITControls.HtmlControl)child);
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
                    ret = WrapUtil((CUITControls.HtmlControl)this._control.GetChildren()[0]);
                }
                catch (ArgumentOutOfRangeException)
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
                uicol.Add(WrapUtil((CUITControls.HtmlControl)uitestcontrol));
            }
            return uicol;
        }

        private ICUITe_ControlBase WrapUtil(CUITControls.HtmlControl control)
        {
            ICUITe_ControlBase _con = null;
            if (control.GetType() == typeof(CUITControls.HtmlButton))
            {
                _con = new HtmlButton();
            }
            else if (control.GetType() == typeof(CUITControls.HtmlCheckBox))
            {
                _con = new HtmlCheckBox();
            }
            else if (control.GetType() == typeof(CUITControls.HtmlComboBox))
            {
                _con = new HtmlComboBox();
            }
            else if (control.GetType() == typeof(CUITControls.HtmlDiv))
            {
                _con = new HtmlDiv();
            }
            else if (control.GetType() == typeof(CUITControls.HtmlEdit) && (string.Compare(control.Type, "password", true) == 0))
            {
                _con = new HtmlPassword();
            }
            else if (control.GetType() == typeof(CUITControls.HtmlEdit))
            {
                _con = new HtmlEdit();
            }
            else if (control.GetType() == typeof(CUITControls.HtmlEditableDiv))
            {
                _con = new HtmlEditableDiv();
            }
            else if (control.GetType() == typeof(CUITControls.HtmlFileInput))
            {
                _con = new HtmlFileInput();
            }
            else if (control.GetType() == typeof(CUITControls.HtmlHyperlink))
            {
                _con = new HtmlHyperlink();
            }
            else if (control.GetType() == typeof(CUITControls.HtmlImage))
            {
                _con = new HtmlImage();
            }
            else if (control.GetType() == typeof(CUITControls.HtmlInputButton))
            {
                _con = new HtmlInputButton();
            }
            else if (control.GetType() == typeof(CUITControls.HtmlLabel))
            {
                _con = new HtmlLabel();
            }
            else if (control.GetType() == typeof(CUITControls.HtmlList))
            {
                _con = new HtmlList();
            }
            else if (control.GetType() == typeof(CUITControls.HtmlRadioButton))
            {
                _con = new HtmlRadioButton();
            }
            else if (control.GetType() == typeof(CUITControls.HtmlSpan))
            {
                _con = new HtmlSpan();
            }
            else if (control.GetType() == typeof(CUITControls.HtmlEditableSpan))
            {
                _con = new HtmlEditableSpan();
            }
            else if (control.GetType() == typeof(Microsoft.VisualStudio.TestTools.UITesting.HtmlControls.HtmlTable))
            {
                _con = new HtmlTable();
            }
            else if (control.GetType() == typeof(CUITControls.HtmlCell))
            {
                _con = new HtmlCell();
            }
            else if (control.GetType() == typeof(Microsoft.VisualStudio.TestTools.UITesting.HtmlControls.HtmlTextArea))
            {
                _con = new HtmlTextArea();
            }
            else if (control.GetType() == typeof(CUITControls.HtmlIFrame))
            {
                _con = new HtmlIFrame();
            }
            else if (control.GetType() == typeof(CUITControls.HtmlCustom))
            {
                switch (control.TagName.ToLower())
                {
                    case "p":
                        _con = new HtmlParagraph();
                        break;
                    case "h1":
                        _con = new HtmlHeading1();
                        break;
                    case "h2":
                        _con = new HtmlHeading2();
                        break;
                    case "h3":
                        _con = new HtmlHeading3();
                        break;
                    case "h4":
                        _con = new HtmlHeading4();
                        break;
                    case "h5":
                        _con = new HtmlHeading5();
                        break;
                    case "h6":
                        _con = new HtmlHeading6();
                        break;
                    case "ul":
                        _con = new HtmlUnorderedList();
                        break;
                    case "ol":
                        _con = new HtmlOrderedList();
                        break;
                    case "li":
                        _con = new HtmlListItem();
                        break;
                    case "ins":
                        _con = new HtmlIns();
                        break;
                    default:
                        _con = new HtmlCustom(control.TagName);
                        break;
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
